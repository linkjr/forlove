using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Tang.Mall.WebUI
{
    /// <summary>
    /// 用于表示读取站点配置文件信息的类。
    /// </summary>
    public class Config
    {
        private static readonly string _siteName = ConfigurationManager.AppSettings["SiteName"];

        /// <summary>
        /// 网站名称
        /// </summary>
        public static string SiteName
        {
            get { return _siteName; }
        }
    }
}