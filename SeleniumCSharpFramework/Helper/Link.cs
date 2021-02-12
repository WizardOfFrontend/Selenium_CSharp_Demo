using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Link
    {
        private static IWebElement element;
        public static void ClickLink(By locator)
        {
            Generic.GetElement(locator).Click();
        }
    }
}
