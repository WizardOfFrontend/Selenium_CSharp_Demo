using SeleniumCSharpFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get("Password");
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get("Username");
        }

        public string GetWebSite()
        {
            return ConfigurationManager.AppSettings.Get("Website");
        }

        public string GetWebSite2()
        {
            return ConfigurationManager.AppSettings.Get("Website2");
        }

        public int GetPageLoadTimeout()
        {
            string timeout = ConfigurationManager.AppSettings.Get("PageLoadTimeout");
            if (timeout == null) // if it's not set, set it to 30sec
                return 30;
            return Convert.ToInt32(timeout); // config value is string. need to convert to int
        }
    }
}
