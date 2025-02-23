using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice; //修改命名空間:https://andy51002000.blogspot.com/2017/10/c-visual-studio-10.html
//1_1-目標：呼叫/hello?id=1，回傳hello 1
[Route("[controller]")]
public class HelloController
{
    [HttpGet("{id?}")]
    public string Get(string id)
    {
        return "hello " + id;
    }
}