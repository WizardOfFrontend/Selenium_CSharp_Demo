using OpenQA.Selenium;
using SeleniumCSharpFramework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.PageObject
{
    public class PrivacyErrorPage: BasePage
    {
        private IWebDriver driver;

        private IWebElement ConnectionNotPrivate_Warning => driver.FindElement(By.Id("main-message"));

        private IWebElement Advancec_Btn => driver.FindElement(By.Id("details-button"));

        private IWebElement Proceed_Lnk => driver.FindElement(By.Id("proceed-link"));

        public PrivacyErrorPage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }

        public void Proceed()
        {
            Advancec_Btn.Click();
            Proceed_Lnk.Click();
        }
    }
}
