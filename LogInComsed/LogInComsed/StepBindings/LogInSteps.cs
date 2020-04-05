using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace LogInComsed
{
    [Binding]
    public class LogInSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"I load Comsed website")]
        public void GivenILoadComsedWebsite()
        {
            LogInPage logInPage = new LogInPage(driver);
            driver.Navigate().GoToUrl(logInPage.homepage);
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"Click on the enter/registration button")]
        public void GivenClickOnTheEnterRegistrationButton()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.ClickRegistrationButton();
        }
        
        [When(@"I enter email address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterEmail(email);
        }
        
        [When(@"I enter password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterPassword(password);
        }
        
        [When(@"I click on the Enter button")]
        public void WhenIClickOnTheEnterButton()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.ClickEnterButton();
        }
        
        [Then(@"The Profile page should be loaded")]
        public void ThenTheProfilePageShouldBeLoaded()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.IsProfilePageDisplayed());
        }
        
        [Then(@"An error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            LogInPage logInPage = new LogInPage(driver);
            Assert.IsTrue(logInPage.IsLogInErrorDispalyed());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;

            }
        }
    }
}
