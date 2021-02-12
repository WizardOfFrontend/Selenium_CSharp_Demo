using OpenQA.Selenium;
using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Browser
    {
        public static void MaxBrowser()
        {
            Repository.Driver.Manage().Window.Maximize();
        }
        public static void GoForward()
        {
            Repository.Driver.Navigate().Forward();
        }
        public static void GoBack()
        {
            Repository.Driver.Navigate().Back();
        }
        public static void RefreshPage()
        {
            Repository.Driver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = Repository.Driver.WindowHandles; 
            if(windows.Count < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index " + index);
            }
            Repository.Driver.SwitchTo().Window(windows[index]);
            MaxBrowser();
        }

        public static void SwitchToParent()
        {
            var windowsids = Repository.Driver.WindowHandles;
            for (int i = windowsids.Count-1; i > 0; i--)
            {
                Repository.Driver.SwitchTo().Window(windowsids[i]);
                Repository.Driver.Close();
            }
            Repository.Driver.SwitchTo().Window(windowsids[0]);
        }

        // iframe
        public static void SwitchToFrame(By locator)
        {
            Repository.Driver.SwitchTo().Frame(Repository.Driver.FindElement(locator));
        }
    }
}
