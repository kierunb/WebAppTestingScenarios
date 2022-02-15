using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.SeleniumTests
{
    public class SiteTests : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly string _pageUrl = "https://www.orlen.pl/pl";

        public SiteTests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            if (_driver != null) _driver.Dispose();
        }

        [Fact]
        public void IsSearchWorking()
        {
            _driver.Navigate().GoToUrl(_pageUrl);

            var searchIcon = _driver.FindElement(By.CssSelector("#button-8d09072c15"));
            searchIcon.Click();
            var searchTextBox = _driver.FindElement(By.CssSelector("#searchbar-m8te3ijq > form > div > input"));
            searchTextBox.SendKeys("benzyna");
            searchTextBox.SendKeys(Keys.Enter);

            var resultCount = _driver.FindElement(By.CssSelector("#container-e89768ff75 > div > div.searchresults.aem-GridColumn.aem-GridColumn--default--12.initialized > div > div > div.cmp-searchresults__results.aem-GridColumn.aem-GridColumn--phone--12.aem-GridColumn--tablet--12.aem-GridColumn--default--9 > div.cmp-searchresults__sort-wrapper > div.cmp-searchresults__results-count > p > span"));
            int resultCountInt = int.Parse(resultCount.Text);

            Assert.True(resultCountInt > 0);       
        }
    }
}
