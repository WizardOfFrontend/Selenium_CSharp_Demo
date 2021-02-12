using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Generic
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return Repository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator) == true)
            {
                return Repository.Driver.FindElement(locator);
            }
            else
            {
                throw new NoSuchElementException("Element Not Found: " + locator.ToString());
            }
        }

        public static Func<IWebDriver,IList<IWebElement>> GetAllElements(By locator)
        {
            return x => x.FindElements(locator);
        }

        public static void TakeScreenShot(string filename = "Screenshot")
        {
            Screenshot screen = Repository.Driver.TakeScreenshot();
            filename = filename + DateTime.Now.ToString("yyyyMMdd_hhmmss") + ".jpeg";
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            return;
        }
    }
}
