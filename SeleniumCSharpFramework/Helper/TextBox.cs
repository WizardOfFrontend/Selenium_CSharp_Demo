using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class TextBox
    {
        private static IWebElement element;
        public static void CelarTextBox(By locator)
        {
            Generic.GetElement(locator).Clear();
        }

        public static void TypeInTextBox(By locator, string text)
        {
            Generic.GetElement(locator).SendKeys(text);        }

       
    }
}
