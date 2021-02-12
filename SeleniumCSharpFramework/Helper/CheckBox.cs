using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class CheckBox
    {
        private static IWebElement element;
        public static bool IsCheckBoxChecked(By locator)
        {
            element = Generic.GetElement(locator);
            string flag = element.GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            return flag.Equals("true") || flag.Equals("checked");
        }

        public static void CheckedCheckBox(By locator)
        {
            Generic.GetElement(locator).Click();
        }
    }
}
