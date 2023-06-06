using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace TestPractice.Selenium.Pages
{
    public class LandingPage
    {
        private WebDriver driver;

        WebDriverWait wait;

        public IWebElement userTextBox => driver.FindElement(By.CssSelector("input[name='username']"));

        public IWebElement passwordTextBox => driver.FindElement(By.CssSelector("input[name='password']"));

        public IWebElement loginBtn => driver.FindElement(By.CssSelector("button[type='submit']"));

        public LandingPage(WebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));           
        }

        public void login()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[name='username']")));
            userTextBox.SendKeys("Admin");
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("input[name='password']")));
            passwordTextBox.SendKeys("admin123");
            loginBtn.Click();
        }

        private Func<IWebDriver, bool> VisibilityOf(IWebElement webElement) 
        { 
            return (driver) => webElement.Displayed;
        }
    }
}
