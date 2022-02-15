using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.PlaywrightTests
{
    public class NBPSiteTests
    {
        [Fact]
        public async Task IsSearchWorking()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true,
            });
            var context = await browser.NewContextAsync();
            // Open new page
            var page = await context.NewPageAsync();

            await page.GotoAsync("https://www.nbp.pl/");
            // Click body
            await page.RunAndWaitForNavigationAsync(async () =>
            {
                await page.ClickAsync("body");
            });
            // Click text=Wyszukaj
            await page.ClickAsync("text=Wyszukaj");
            // Assert.AreEqual("https://www.nbp.pl/home.aspx?f=/wyszukaj.htm", page.Url);
            // Click input[name="search"]
            await page.ClickAsync("input[name=\"search\"]");
            // Fill input[name="search"]
            await page.FillAsync("input[name=\"search\"]", "stopy procentowe");
            // Click button:has-text("szukaj")
            await page.ClickAsync("button:has-text(\"szukaj\")");

            var content = await page.Locator("#___gcse_0 > div > div > div > div.gsc-wrapper > div.gsc-resultsbox-visible > div.gsc-resultsRoot.gsc-tabData.gsc-tabdActive > div").InnerTextAsync();

            Assert.True(content?.Length > 0);
        }
    }
}
