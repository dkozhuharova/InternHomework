using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1.WebElements
{
    class LogInPage
    {
        public string homepage = "http://testing-ground.scraping.pro/login";

        private IWebDriver driver;

        readonly By userNameField = By.Id("usr");
        readonly By passwordField = By.Id("pwd");
        readonly By LogInButton = By.CssSelector("[type='submit']");
        readonly By WelcomeMessage = By.CssSelector("#case_login > h3");

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(userNameField).Clear();
            driver.FindElement(userNameField).SendKeys(username);
        }

        public void enterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void clickLogInButton()
        {
            driver.FindElement(LogInButton).Click();
        }

        public bool isWelcomeMessageDisplayed()
        {
            return driver.FindElement(WelcomeMessage).Displayed;
        }

        internal class enterUsername
        {
        }
    }
}
