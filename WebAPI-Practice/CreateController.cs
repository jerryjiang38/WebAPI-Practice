using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//8-目標：接收Json，並且手動設定HttpStatusCode
public class Content
{
    public string Title { get; set; }
    public string Body { get; set; }
}
[Route("[controller]")]
public class CreateController: ControllerBase
{
    [HttpGet("html")]
    public ContentResult GetHtml()
    {
        var html = "<html><body><h1>Hi from HTML</h1></body></html>";
        return Content(html, "text/html"); //在字串中加入html標籤
    }
    [HttpPost] //500:沒有正確找到方法
    public string Add([FromBody] Content content) //在/create的Body/raw中輸入
    {
        Response.StatusCode = 201;
        return $"Title:{content.Title}, Body:{content.Body}";
    }
}
/*
{
    "Title":"abc",
    "body":"456"
}
*/