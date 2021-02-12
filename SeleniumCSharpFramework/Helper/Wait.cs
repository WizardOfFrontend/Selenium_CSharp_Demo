using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SeleniumCSharpFramework.Helper
{
    public class Wait
    {
        public static IWebElement WaitForElement(By locator, int totalSeconds, int checkInterval)
        {
            Repository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(Repository.Driver, TimeSpan.FromSeconds(totalSeconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(checkInterval);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            return Generic.GetElement(locator);
        }

        public static IWebElement WaitForElement(IWebElement element, int totalSeconds, int checkInterval)
        {
            Repository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(Repository.Driver, TimeSpan.FromSeconds(totalSeconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(checkInterval);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(element));
            return element;
        }
        public static void  WaitForTitle(string title, int totalSeconds, int checkInterval)
        {
            Repository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(Repository.Driver, TimeSpan.FromSeconds(totalSeconds));
            wait.PollingInterval = TimeSpan.FromMilliseconds(checkInterval);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            wait.Until(ExpectedConditions.TitleContains(title));
        }

        public static IList<IWebElement> WaitForAutoSuggestList(By locator, int totalSeconds, int checkInterval)
        {
            Repository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(Repository.Driver, TimeSpan.FromSeconds(totalSeconds))
            {
                PollingInterval = TimeSpan.FromMilliseconds(checkInterval),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            return wait.Until(Generic.GetAllElements(locator));
        }
    }
}
