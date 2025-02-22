using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//3_1-目標：建立一個BaseController，讓其他Controller繼承，並且可以使用BaseController的函數
[Route("api/[controller]")]
public class BaseController
{
    [HttpGet("get")] //在/api/base/get取得hello world
    public string Get()
    {
        return "hello world";
    }
}