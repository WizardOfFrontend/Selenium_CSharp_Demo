using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Button
    {
        private static IWebElement element;
        public static bool IsButtonEnabled(By locator)
        {
            return Generic.GetElement(locator).Enabled;
        }

        public static void ClickButton(By locator)
        {
            Generic.GetElement(locator).Click();
        }

        // Button's value attribute is button text
        public static string GetButtonText(By locator)
        {
            element = Generic.GetElement(locator);
            if (element.GetAttribute("value") == null)
            {
                return string.Empty;
            }
            else
            {
                return element.GetAttribute("value");
            }
        }
    }
}
