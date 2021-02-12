using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumCSharpFramework.Configuration;
using SeleniumCSharpFramework.Helper;
using SeleniumCSharpFramework.Interfaces;
using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.BaseClass
{
    // BaseClass will take care of launching and closing the browser
    // based on the configuration specified in the App.config file.
    // [TestCalss] is needed to use [AssemblyInitialize]
    [TestClass]
    public class BaseClass
    {        
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            Repository.Config = new AppConfigReader();
            switch (Repository.Config.GetBrowser())
            {
                case BrowserType.FireFox:
                    Repository.Driver = GetFirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    Repository.Driver = GetChromeDriver();
                    break;
                default:
                    throw new Exception($"Driver Not Found: {Repository.Config.GetBrowser().ToString()}");
            }
            Browser.MaxBrowser();

        }
        [AssemblyCleanup]
        public static void TearDown()
        {
            if(Repository.Driver != null)
            {
                Repository.Driver.Quit();
            }
        }
    }
    
}
