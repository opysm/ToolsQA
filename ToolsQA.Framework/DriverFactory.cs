using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA.Framework
{
    public static class DriverFactory
    {
        private static IWebDriver driver;

        public static IWebDriver Get()
        {
            return driver;
        }

        public static void Initialize(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = url;
        }
    }
}
