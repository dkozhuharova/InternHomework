using HomeworkDobi.WebElements;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace HomeworkDobi
{
    [Binding]
    public class SearchItemSteps : IDisposable
    {
        private ChromeDriver driver = new ChromeDriver();

        [Given(@"Navigate to Comsed homepage")]
        public void GivenNavigateToComsedHomepage()
        {
            SearchItemPage searchItemPage = new SearchItemPage(driver);
            driver.Navigate().GoToUrl(searchItemPage.homepage);
            driver.Manage().Window.Maximize();
        }

        [When(@"I enter ""(.*)"" to the searching field")]
        public void WhenIEnterToTheSearchingField(string SearchingWord)
        {
            SearchItemPage searchItemPage = new SearchItemPage(driver);
            searchItemPage.EnterSearchingWord(SearchingWord);
        }

        [When(@"Click on the searching button")]
        public void WhenClickOnTheSearchingButton()
        {
            SearchItemPage searchItemPage = new SearchItemPage(driver);
            searchItemPage.ClickSearchButton();
        }
        
        [Then(@"All Star Wars items should be listed")]
        public void ThenAllStarWarsItemsShouldBeListed()
        {
            SearchItemPage searchItemPage = new SearchItemPage(driver);
            Assert.IsTrue(searchItemPage.IslistedItemsDisplayed());
        }

        public void Dispose()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            };
        }
    }
}
