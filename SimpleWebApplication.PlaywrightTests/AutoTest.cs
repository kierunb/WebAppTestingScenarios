using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SimpleWebApplication.PlaywrightTests;

public class AutoTest
{
    [Fact]
    public async Task Test()
    {
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false,
        });
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();
        await page.GotoAsync("https://www.nbp.pl/");
        await page.GetByRole(AriaRole.Link, new() { NameString = "Wyszukaj" }).ClickAsync();
        await page.WaitForURLAsync("https://www.nbp.pl/home.aspx?f=/wyszukaj.htm");
        await page.GetByRole(AriaRole.Textbox, new() { NameString = "szukaj" }).ClickAsync();
        await page.GetByRole(AriaRole.Textbox, new() { NameString = "szukaj" }).FillAsync("asdfasdf");
        await page.Locator("#contentholder").ClickAsync();
        await page.GetByRole(AriaRole.Textbox, new() { NameString = "szukaj" }).FillAsync("Dorota");
        await page.GetByRole(AriaRole.Button, new() { NameString = "szukaj" }).ClickAsync();
    }
}
