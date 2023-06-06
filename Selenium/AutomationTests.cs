using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;

using TestPractice.Selenium.Pages;

namespace TestPractice.Selenium
{
    [TestClass]
    public class AutomationTests
    {
        WebDriver driver;

        [TestInitialize]
        public void setup()
        {
            this.driver = DriverFactory.GetDriver("firefox");
            this.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        [TestMethod]
        public void login()
        {
            LandingPage landingPage = new LandingPage(driver);
            landingPage.login();
            driver.Url.Should().Be("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
        }

        [TestCleanup]
        public void quit()
        {
            driver.Quit();
        }
    }
}
