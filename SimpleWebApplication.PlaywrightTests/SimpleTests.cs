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

        [Fact]
        public async Task Test2()
        {
            
          
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync();
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.pkobp.pl/");


            await page.GetByLabel("Przycisk Zaakceptuj zgodę na wykorzystywanie plików cookies").ClickAsync();

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").ClickAsync();

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").ClickAsync();

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").PressAsync("ArrowRight");

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").PressAsync("ArrowRight");

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").PressAsync("ArrowRight");

            await page.GetByLabel("Wpisz wartość dla pola Pole kwota pożyczki").FillAsync("5 0000");

            await page.GetByLabel("Wpisz wartość dla suwaka Pole ilość rat").ClickAsync();


        }
    }
}   