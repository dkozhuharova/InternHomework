using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDobi.WebElements
{
    class SearchItemPage
    {
        public string homepage = "https://comsed.net";

        private IWebDriver driver;

        readonly By SearchingField = By.Id("input-search");
        readonly By SearchButton = By.CssSelector("#button-search > i");
        readonly By listedItems = By.CssSelector("body > div.container.mt15 > div > section > div.col-xs-12.col-sm-12.category-filtering > div:nth-child(3)");

        public SearchItemPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void EnterSearchingWord(string SearchingWord)
        {
            driver.FindElement(SearchingField).Clear();
            driver.FindElement(SearchingField).SendKeys(SearchingWord);
        }

        public void ClickSearchButton()
        {
            driver.FindElement(SearchButton).Click();
        }

        public bool IslistedItemsDisplayed()
        {
            return driver.FindElement(listedItems).Displayed;
        }

    }
}
