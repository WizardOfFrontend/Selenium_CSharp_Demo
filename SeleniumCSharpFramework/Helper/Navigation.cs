using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Navigation
    {
        public static void NavigateToUrl(string url)
        {
            Repository.Driver.Navigate().GoToUrl(url);
        }
    }
}
