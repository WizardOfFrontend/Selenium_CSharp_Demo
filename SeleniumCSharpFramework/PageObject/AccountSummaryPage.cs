using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFramework.BaseClass;
using SeleniumCSharpFramework.Helper;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.PageObject
{
    public class AccountSummaryPage: BasePage
    {
        private IWebDriver driver;
        public AccountSummaryPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }
        public IWebElement CashAccounts_Header => driver.FindElement(By.XPath("//h2[text()='Cash Accounts']"));

        public bool IsHeaderDisplayed()
        {
            var wait = new WebDriverWait(driver,new TimeSpan(0,0,20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h2[text()='Cash Accounts']")));           
            return CashAccounts_Header.Displayed;
        }

    }
}
