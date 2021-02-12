using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpFramework.BaseClass;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

using SeleniumCSharpFramework.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.PageObject
{
    public class LogInPage: BasePage
    {
        private IWebDriver driver;

        #region WebElement

        private IWebElement LoginTbox => driver.FindElement(By.Id("user_login"));

        private IWebElement PasswordTbox => driver.FindElement(By.Id("user_password"));

        private IWebElement SignInBtn => driver.FindElement(By.XPath("//input[@name='submit']"));

        private IWebElement Error => driver.FindElement(By.CssSelector("div.alert"));

        #endregion
        public LogInPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        #region Actions

        public void Login(string username, string password)
        {
            LoginTbox.SendKeys(username);
            PasswordTbox.SendKeys(password);
            SignInBtn.Click();
        }

        public bool IsErrorDisplayed()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("div.alert")));
            return Error.Displayed;
            
        }
        #endregion
    }
}
