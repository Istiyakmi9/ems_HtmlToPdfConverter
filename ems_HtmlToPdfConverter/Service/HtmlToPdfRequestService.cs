using PuppeteerSharp;

namespace ems_HtmlToPdfConverter.Service
{
    public class HtmlToPdfRequestService
    {
        public async Task<double> GetContentWidth(string htmlContent)
        {
            var launchOptions = new LaunchOptions
            {
                Headless = true
            };

            using (var browser = await Puppeteer.LaunchAsync(launchOptions))
            {
                var page = await browser.NewPageAsync();
                await page.SetContentAsync(htmlContent);

                var bodyHandle = await page.QuerySelectorAsync("body");
                var size = await bodyHandle.BoxModelAsync();

                // Assuming width is the relevant dimension for your content
                return size.Width;
            }
        }
    }
}
