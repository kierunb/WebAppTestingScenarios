using Microsoft.Playwright;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.PlaywrightTests
{
    public class SimpleTests
    {
        [Fact]
        public async Task Test1()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();
            await page.GotoAsync("https://playwright.dev/dotnet");
            await page.ScreenshotAsync(new PageScreenshotOptions { Path = "screenshot.png" });
        }
    }
}   