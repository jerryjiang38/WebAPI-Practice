using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//4_2-目標：使用Model，回傳註冊成功的訊息
public class UserModel
{
    public string UserName { get; set; }
    public int UserAge { get; set; }
}
[Route("[controller]")]
public class DataController
{
    [HttpGet("get")] //在/data/get?UserName=a&UserAge=20取得
    public string Register(UserModel model)
    {
        return $"User {model.UserName},({model.UserAge} age) registered successfully!";
    }
}