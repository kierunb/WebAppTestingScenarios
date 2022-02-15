using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.SeleniumTests
{
    public class SuiteTests : IDisposable
    {
        public IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }
        public IJavaScriptExecutor js { get; private set; }
        public SuiteTests()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<String, Object>();
        }
        public void Dispose()
        {
            driver.Quit();
        }
        [Fact]
        public void T1()
        {
            driver.Navigate().GoToUrl("https://www.nbp.pl/");
            driver.Manage().Window.Size = new System.Drawing.Size(1817, 1680);
            driver.FindElement(By.LinkText("Wyszukaj")).Click();
            driver.FindElement(By.Id("gsc-i-id1")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".gsc-search-button-v2"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            driver.FindElement(By.Id("gsc-i-id1")).SendKeys("stopy procentowe");
            driver.FindElement(By.CssSelector(".gsc-search-button-v2")).Click();
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            Assert.True(true);
        }
    }
}
