using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
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