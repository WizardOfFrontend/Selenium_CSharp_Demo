using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumCSharpFramework.Helper;
using SeleniumCSharpFramework.Settings;
using OpenQA.Selenium;
using System.Threading;
using SeleniumCSharpFramework.PageObject;
using SeleniumCSharpFramework.BaseClass;
using SeleniumCSharpFramework.Configuration;

namespace SeleniumCSharpFramework.TestScript
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class TestComponents
    {
        IWebElement element;
        HomePage hp = new HomePage(Repository.Driver);
        LogInPage lp = new LogInPage(Repository.Driver);
        AccountSummaryPage asp = new AccountSummaryPage(Repository.Driver);
        PrivacyErrorPage pep = new PrivacyErrorPage(Repository.Driver);

        //[TestInitialize]
        //public void init()
        //{            
        //    Navigation.NavigateToUrl(Repository.Config.GetWebSite());
            
        //}
       
        [DataRow("wrongUserName","wrongPassword")]
        [DataRow("username", "wrongPassword")]
        [DataRow("wrongUserName", "password")]
        [DataRow("", "password")]
        [DataRow("username", "")]
        [DataRow("", "")]
        [DataTestMethod]
        public void User_Login_With_Invalid_Credentials(string username, string password)
        {
            Navigation.NavigateToUrl(Repository.Config.GetWebSite());
            hp.NavigateToLogInPage();
            lp.Login(username,password);
            if (lp.GetTitle().Contains("Privacy"))
            {
                pep.Proceed();
            }
            Assert.IsTrue(lp.IsErrorDisplayed());            
        }

        [TestMethod]
        public void User_Login_With_Valid_Credentials()
        {
            Navigation.NavigateToUrl(Repository.Config.GetWebSite());
            hp.NavigateToLogInPage();
            lp.Login(Repository.Config.GetUsername(), Repository.Config.GetPassword());
            if (lp.GetTitle().Contains("Privacy"))
            {
                pep.Proceed();
            }
            Assert.IsTrue(asp.IsHeaderDisplayed());
        }               
    }
}
