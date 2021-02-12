using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{    
    public class DropDownList
    {
        public static SelectElement select;
       public static void SelectByIndex(By locator, int index)
        {
            select = new SelectElement(Generic.GetElement(locator));
            select.SelectByIndex(index);
        }

        public static void SelectByText(By locator, string text)
        {
            select = new SelectElement(Generic.GetElement(locator));
            select.SelectByText(text);
        }

        public static void SelectByValue(By locator, string value)
        {
            select = new SelectElement(Generic.GetElement(locator));
            select.SelectByValue(value);
        }

        public static IList<string> GetAllItems(By locator)
        {
            select = new SelectElement(Generic.GetElement(locator));
            return select.Options.Select(x => x.Text).ToList();
        }
    }
}
