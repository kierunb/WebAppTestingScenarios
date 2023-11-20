using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace SimpleWebApplication.SeleniumTests
{
    public class SimpleTests : IDisposable
    {

        private readonly IWebDriver _driver;
        private readonly string _pageUrl = "https://localhost:7155/";


        public SimpleTests()
        {
            _driver = new ChromeDriver();
        }

        public void Dispose()
        {
            _driver?.Dispose();
        }

        [Fact]
        public void IndexPage_Contains_WelcomeText()
        {
            _driver.Navigate().GoToUrl(_pageUrl);

            IWebElement welcomeText = _driver.FindElement(By.XPath("/html/body/div[1]/main/div/h1"));

            Assert.Equal("Welcome", welcomeText.Text);
        }
    }
}