using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//6-目標：回傳Html
[Route("[controller]")]
public class HiController : ControllerBase
{
    [HttpGet("html")]
    public ContentResult GetHtml()
    {
        var html = "<html><body><h1>Hi from HTML</h1></body></html>";
        return Content(html, "text/html"); //在字串中加入html標籤
    }
    
}