using System;
using System.Collections.Generic;
using System.Text;

namespace Commom.Utility.Web
{
    public class GetHostInfo
    {
        private static string macAddress = string.Empty;
        private static string ip = string.Empty;
        private static string _HostName = string.Empty;

        /// <summary>
        /// 获取Mac地址
        /// </summary>
        /// <returns></returns>
        //public static string GetMacAddress()
        //{
        //    if (string.IsNullOrEmpty(macAddress))
        //    {
        //        System.Management.ManagementClass mc1 = new System.Management.ManagementClass("Win32_NetworkAdapter");
        //        System.Management.ManagementObjectCollection moc1 = mc1.GetInstances();
        //        foreach (System.Management.ManagementObject mo in moc1)
        //        {
        //            if (mo["NetConnectionStatus"] != null && mo["NetConnectionStatus"].ToString() == "2")
        //            {
        //                macAddress = mo["MacAddress"].ToString();
        //            }
        //        }
        //    }
        //    return macAddress;
        //}
        public static string GetIp()
        {
            if (string.IsNullOrWhiteSpace(ip))
            {
                string MachineName = System.Net.Dns.GetHostName();
                ip = System.Net.Dns.Resolve(MachineName).AddressList[0].ToString();
            }
            return ip;
        }

        /// <summary>
        ///  主机名
        /// </summary>
        public static string GetHostName()
        {
            if (string.IsNullOrWhiteSpace(_HostName))
            {
                _HostName = System.Net.Dns.GetHostName();
            }
            return _HostName;

        }
        ///// <summary>
        ///// 本机ip标识
        ///// </summary>
        ///// <returns></returns>
        //public static string GetLocalMachineIdentity()
        //{
        //    string[] ipTemp = Common.Util.GetIp().Split('.');

        //    return ipTemp[0].PadLeft(3, '0') + ipTemp[1].PadLeft(3, '0') + ipTemp[2].PadLeft(3, '0') + ipTemp[3].PadLeft(3, '0');
        //}
    }
}
