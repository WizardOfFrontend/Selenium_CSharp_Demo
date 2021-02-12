using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumCSharpFramework.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.PageObject
{
    public class HomePage:BasePage
    {
        private IWebDriver driver;

        private IWebElement MoreServiceBtn => driver.FindElement(By.XPath("//a[@id='online-banking']"));


        public HomePage(IWebDriver _driver) : base(_driver)
        {
            this.driver = _driver;
        }


    }
}
