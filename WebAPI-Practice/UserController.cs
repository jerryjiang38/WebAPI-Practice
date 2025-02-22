using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//1_2-目標：建立一個UserController，並且可以使用Me函數
[Route("[controller]")]
public class UserController
{
    [HttpPost("{name}")] //在Postman中輸入/user/123
    public string Me(string name)
    {
        Console.WriteLine(name);
        return "hello world";
    }
}