using ems_HtmlToPdfConverter.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ems_HtmlToPdfConverter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlToPdfRequestController : ControllerBase
    {
        private readonly HtmlToPdfRequestService _htmlToPdfRequestService;

        public HtmlToPdfRequestController(HtmlToPdfRequestService htmlToPdfRequestService)
        {
            _htmlToPdfRequestService = htmlToPdfRequestService;
        }

        [HttpGet("ConvertToPdfFromHtml")]
        public async Task ConvertToPdfFromHtml()
        {
            string htmlContent = "<html><body><h1>Hello, World!</h1><table><tr><td>Cell 1</td><td>Cell 2</td></tr></table></body></html>"; // Replace this with your HTML content

            var contentWidth = await _htmlToPdfRequestService.GetContentWidth(htmlContent);
        }
    }
}
