using System;
namespace EnterpriseObjects
{
    [Flags]
    public enum MailResult
    {
        Success,
        Fail,
        Cancel,
        Timeout,
        Unknow
    }
}