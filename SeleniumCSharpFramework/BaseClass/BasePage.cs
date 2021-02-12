using OpenQA.Selenium;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;
using SeleniumCSharpFramework.PageObject;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumCSharpFramework.BaseClass
{
    public class BasePage
    {
        private IWebDriver driver;

        #region WebElement
        public IWebElement BrandTxt => driver.FindElement(By.ClassName("brand"));

        protected IWebElement SearchBox => driver.FindElement(By.Id("searchTerm"));

        public IWebElement Signin_Btn => driver.FindElement(By.Id("signin_button"));
                     

        // Menu
        public IWebElement HomeMenu => driver.FindElement(By.Id("homeMenu"));

        public IWebElement OnlineBankingMenu => driver.FindElement(By.Id("onlineBankingMenu"));

        public IWebElement Feedback => driver.FindElement(By.Id("feedback"));

        

        #endregion

        public BasePage(IWebDriver _driver)
        {
            this.driver = _driver;
        }

        #region Actions
        public void NavigateToLogInPage()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("signin_button")));
            Signin_Btn.Click();
        }

        public string GetTitle()
        {
           return driver.Title; 
        }
        #endregion

    }
}
