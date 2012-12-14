using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace EnterpriseObjects
{
    /*************************************************************************************
     * CLR  Version       4.0.30319.17929
     * Class   Name       NetworkHelper
     * Machine Name       LUMIA800
     * Namespace          EnterpriseObjects
     * File Name          NetworkHelper
     * Created Time       2012/12/14 12:26:55
     * Author  Name       常伟华 Changweihua
     * Website            http://www.cmono.net
     * Email              changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
    *************************************************************************************/
    /// <summary>
    /// 网络帮助类
    /// </summary>
    /// 
    public class NetworkHelper
    {
        private const int INTERNET_CONNECTION_MODEM = 1;
        private const int INTERNET_CONNECTION_LAN = 2;

        [DllImport("winInet.dll")]
        private static extern bool InternetGetConnectedState(ref int dwFlag,int dwReserved);


        /// <summary>
        /// 判断网络的连接状态
        /// </summary>
        /// <returns>
        /// 网络状态(1-->未联网;2-->采用调治解调器上网;3-->采用网卡上网)
        ///</returns>
        public static NetStatus GetConnectionStatus(string netAddress)
        {
            NetStatus netStatus = NetStatus.None;
            int dwFlag = new int();

            if (!InternetGetConnectedState(ref dwFlag, 0))
            {
                //没有连上互联网
                netStatus = NetStatus.None;
            }
            else if((dwFlag&INTERNET_CONNECTION_MODEM)!=0)
            {
                //采用调制解调器上网，需要进一步判断能否登录具体网址
                if (PingNetAddress(netAddress))
                {
                    //可以ping通，网络OK
                    netStatus = NetStatus.ModemLink;
                }
                else 
                {
                    //不可以ping通，网络补OK
                    netStatus = NetStatus.ModemUnlink;
                }
            }
            else if ((dwFlag & INTERNET_CONNECTION_LAN) != 0)
            {
                //采用网卡上网,需要进一步判断能否登录具体网站
                if (PingNetAddress(netAddress))
                {
                    //可以ping通给定的网址,网络OK
                    netStatus = NetStatus.LanCardLink;
                }
                else
                {
                    //不可以ping通给定的网址,网络不OK
                    netStatus = NetStatus.LanCardUnlink;
                }
            }

            return netStatus;
        }


        /// <summary>
        /// ping 具体的网址看能否ping通
        /// </summary>
        /// <param name="strNetAdd"></param>
        /// <returns></returns>
        private static bool PingNetAddress(string strNetAdd)
        {
            bool Flage = false;
            Ping ping = new Ping();
            try
            {
                PingReply pr = ping.Send(strNetAdd, 3000);
                if (pr.Status == IPStatus.TimedOut)
                {
                    Flage = false;
                }
                if (pr.Status == IPStatus.Success)
                {
                    Flage = true;
                }
                else
                {
                    Flage = false;
                }
            }
            catch
            {
                Flage = false;
            }
            return Flage;
        }

    }


    public enum NetStatus
    { 
        [EnumDescription("网络未连接")]
        None,
        [EnumDescription("采用调治解调器上网")]
        ModemLink,
        [EnumDescription("连不上微博哟，您可以尝试重新启动一个Modem")]
        ModemUnlink,
        [EnumDescription("采用网卡上网")]
        LanCardLink,
        [EnumDescription("网络没有联通，是不是没有输入账号和密码呢？")]
        LanCardUnlink
    }

}
