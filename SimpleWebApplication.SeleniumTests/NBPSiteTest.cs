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
            driver.FindElement(By.Name("phrase")).Click();
            {
                var element = driver.FindElement(By.CssSelector(".d-lg-inline:nth-child(1)"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.Name("phrase")).SendKeys("złoto");
            driver.FindElement(By.CssSelector("#ajaxsearchlite1 .promagnifier svg")).Click();
            Assert.True(true);
        }
    }
}
