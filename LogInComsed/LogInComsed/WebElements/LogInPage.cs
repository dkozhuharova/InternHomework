using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInComsed
{
    public class LogInPage
    {
        public string homepage = "https://comsed.net/";

        public readonly string correctEmail = "testcases@abv.bg";
        public readonly string correctPassword = "Testing123";

        public readonly string wrongEmail = "testcases@abv.com";
        public readonly string wrongPassword = "Testing";

        private IWebDriver driver;

        readonly By RegistrationButton = By.CssSelector("body > header > div.container > div > div.col-xs-5.col-sm-8.col-md-9 > ul > li:nth-child(1) > a");
        readonly By emailField = By.Id("input-email");
        readonly By passwordField = By.Id("input-password");
        readonly By EnterButton = By.CssSelector("#content > div > div:nth-child(2) > div > form > input");
        readonly By ProfilePage = By.CssSelector("body");
        readonly By errorMessage = By.CssSelector("body > div.container.mt15 > div > div > div > div > div.alert.alert-danger");

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void ClickRegistrationButton()
        {
            driver.FindElement(RegistrationButton).Click();
        }

        public void EnterEmail(string email)
        {
            driver.FindElement(emailField).Clear();
            driver.FindElement(emailField).SendKeys(email);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).Clear();
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickEnterButton()
        {
            driver.FindElement(EnterButton).Click();
        }
        public bool IsProfilePageDisplayed()
        {
            return driver.FindElement(ProfilePage).Displayed;
        }
        public bool IsLogInErrorDispalyed()
        {
            return driver.FindElement(errorMessage).Displayed;
        }

    }
}
