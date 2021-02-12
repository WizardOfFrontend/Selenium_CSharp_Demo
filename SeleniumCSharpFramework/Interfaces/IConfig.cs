using SeleniumCSharpFramework.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        String GetUsername();
        String GetPassword();
        String GetWebSite();
        String GetWebSite2();

        int GetPageLoadTimeout();
    }
}
