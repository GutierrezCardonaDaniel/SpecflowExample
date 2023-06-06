using System;
using System.Collections.Generic;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestPractice.Selenium
{
    public class DriverFactory
    {
        private static readonly Func<WebDriver> getChrome = () => new ChromeDriver();
        private static readonly Func<WebDriver> getFireFox = () => new FirefoxDriver();

        private static readonly Dictionary<string, Func<WebDriver>> drivers = new Dictionary<string, Func<WebDriver>>()
        {
            { "chrome", getChrome },
            { "firefox", getFireFox}
        };

        public static WebDriver GetDriver(string browser)
        {
            return drivers[browser].Invoke();
        }
    }
}

