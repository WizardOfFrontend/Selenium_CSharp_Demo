using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Radio
    {
        public static bool IsRadioButtonSelected(By locator)
        {
            string flag = Generic.GetElement(locator).GetAttribute("checked");
            if (flag == null)
            {
                return false;
            }
            else
            {
                return flag.Equals("true") || flag.Equals("checked");
            }
        }

        public static void ClickRadioButton(By locator)
        {
            Generic.GetElement(locator).Click();
        }
    }
}
