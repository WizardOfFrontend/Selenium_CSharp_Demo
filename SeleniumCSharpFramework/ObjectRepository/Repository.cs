using OpenQA.Selenium;
using SeleniumCSharpFramework.Interfaces;
using SeleniumCSharpFramework.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Settings
{
    // This class contains the objects and proeprteis which will be used by
    // other classes in teh framework
    public class Repository
    {
        // need IConfig to read data from the config file
        public static IConfig Config { get; set; }
        // need IWebDriver to launch the browser based on 
        // the configuration
        public static IWebDriver Driver { get; set; }

        //public static HomePage hP;
        //public static LogInPage lP;
    }
}
