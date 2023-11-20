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
                Headless = false,
            });
            var context = await browser.NewContextAsync();

            var page = await context.NewPageAsync();

            await page.GotoAsync("https://nbp.pl/");

            await page.GetByRole(AriaRole.Searchbox, new() { Name = "Search input" }).ClickAsync();

            await page.GetByRole(AriaRole.Searchbox, new() { Name = "Search input" }).FillAsync("złoto");

            await page.GetByRole(AriaRole.Button, new() { Name = "Search magnifier button" }).ClickAsync();
            //Assert.True(content?.Length > 0);
        }
    }
}
