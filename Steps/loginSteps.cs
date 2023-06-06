using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium;

using TechTalk.SpecFlow;

using TestPractice.Selenium;
using TestPractice.Selenium.Pages;

namespace TestPractice.Steps
{
    [Binding]
    public class loginSteps
    {
        WebDriver driver;

        [Given(@"I am in the landing page using (.*)")]
        public void iAmInTheLandingPageUsingChrome(string browser)
        {
            this.driver = DriverFactory.GetDriver(browser);
            this.driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
        }

        [When(@"I login into the application using admin credentials")]
        public void iLoginIntoTheApplicationUsingAdminCredentials()
        {
            LandingPage landingPage = new LandingPage(driver);
            landingPage.login();
        }

        [Then(@"I should get to the admin dashboard page")]
        public void iShouldGetToTheAdminDashboardPage()
        {
            driver.Url.Should().Be("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index");
        }

        [AfterScenario]
        public void quitDriver()
        {
            driver.Quit();
        }
    }
}
