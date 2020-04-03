using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Practice1.WebElements;
using System;
using TechTalk.SpecFlow;

namespace Practice1
{
    [Binding]
    public class LoginSteps
    {
     private ChromeDriver driver = new ChromeDriver();

    [Given(@"I navigate to Web Scraper home page")]
    public void GivenINavigateToWebScraperHomePage()
    {
        LogInPage logInPage = new LogInPage(driver);
     driver.Navigate().GoToUrl(logInPage.homepage);
    }

    [When(@"I enter ""(.*)"" in the username field")]
    public void WhenIEnterInTheUsernameField(string username)
    { 
      LogInPage logInPage = new LogInPage(driver);

       logInPage.EnterUsername(username);
    
     }

    [When(@"I enter ""(.*)"" in the password field")]
    public void WhenIEnterInThePasswordField(string password)
    { 
        LogInPage logInPage = new LogInPage(driver);
      
        logInPage.enterPassword(password);
    
      
    }


    [When(@"I click on Log in button")]
        public void WhenIClickOnLogInButton()
    
     {
            LogInPage logInPage = new LogInPage(driver);

            logInPage.clickLogInButton();
            
     }
        
        [Then(@"I should see Welcome message")]
        public void ThenIShouldSeeWelcomeMessage()
    
        {
            LogInPage loginPage = new LogInPage(driver);

            Assert.IsTrue(loginPage.isWelcomeMessageDisplayed());
        }
    }
}
