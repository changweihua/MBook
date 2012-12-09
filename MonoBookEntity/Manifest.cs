using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace MonoBookEntity
{
    /*************************************************************************************
     * CLR 版本:       4.0.30319.586
     * 类 名 称:       Manifest
     * 机器名称:       HSERVER
     * 命名空间:       MonoBookEntity
     * 文 件 名:       Manifest
     * 创建时间:       2012/12/8  9:40:01
     * 作    者:       常伟华 Changweihua
     * 签    名:       To be or not, it is not a problem !
     * 网    站:       http://www.cmono.net
     * 邮    箱:       changweihua@outlook.com
     * 
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    /// <summary>
    /// 添加类描述
    /// </summary>
    /// 

    [XmlRoot("mainfest")]
    public class Manifest
    {
        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("fileBytes")]
        public string Filebytes { get; set; }

        [XmlElement("application")]
        public string Application { get; set; }

        [XmlElement("files")]
        public ManifestFiles ManifestFiles { get; set; }

    }

    public class ManifestFiles
    {
        [XmlElement("file")]
        public ManifestFile[] Files { get; set; }

        [XmlElement("base")]
        public string BaseUrl { get; set; }
    }

    public class ManifestFile
    {
        [XmlElement("source")]
        public string Source { get; set; }

        [XmlElement("hash")]
        public string Hash { get; set; }
    }

    public class Application
    {
        [XmlAttribute("applicationId")]
        public string ApplicationId { get; set; }

        [XmlElement("location")]
        public string Location { get; set; }

        [XmlElement("entryPoint")]
        public EntryPoint EntryPoint { get; set; }
    }

    public class EntryPoint
    {
        [XmlAttribute("file")]
        public string File { get; set; }

        [XmlAttribute("parameters")]
        public string Parameters { get; set; }
    }

    public class UpdaterConfigurationView
    {
        private static XmlDocument document = new XmlDocument();
        private static readonly string xmlFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "updateconfiguration.config");

        static UpdaterConfigurationView()
        {
            document.Load(xmlFileName);
        }

        public string Version
        {
            get
            {
                return document.SelectSingleNode("applicationUpdater").Attributes["version"].Value;
            }
            set
            {
                document.SelectSingleNode("applicationUpdater").Attributes["version"].Value = value;
                document.Save(xmlFileName);
            }
        }

        public string ApplicationId
        {
            get
            {
                return document.SelectSingleNode("applicationUpdater").Attributes["applicationId"].Value;
            }
            set
            {
                document.SelectSingleNode("applicationUpdater").Attributes["applicationId"].Value = value;
                document.Save(xmlFileName);
            }
        }

        public string ManifestUri
        {
            get
            {
                return document.SelectSingleNode("applicationUpdater").Attributes["manifestUri"].Value;
            }
            set
            {
                document.SelectSingleNode("applicationUpdater").Attributes["manifestUri"].Value = value;
                document.Save(xmlFileName);
            }
        }
    }

}
