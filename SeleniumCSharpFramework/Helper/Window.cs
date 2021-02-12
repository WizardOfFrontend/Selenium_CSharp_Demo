using SeleniumCSharpFramework.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpFramework.Helper
{
    public class Window
    {
        public static string GetTitle()
        {
            return Repository.Driver.Title;
        }
    }
}
