using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//5_3-目標：使用多種不同Json來源傳入
public class Model1
{
    [FromRoute]
    public int n1 { get; set; }
    [FromQuery]
    public int n2 { get; set; }
}
public class Model2
{
    public int n3 { get; set; }
}
[Route("[controller]")]
public class FromController
{
    [HttpGet("get/{n1}")] //同時接收路由參數與Query參數 //從/from/get/13?n2=5,Body 輸入{"n3":7}
    public string Get(Model1 model, [FromBody] Model2 model2) //[FromBody]無法與其他類型放在同一個Model中
    {
        return $"n1={model.n1}, n2={model.n2}, n3={model2.n3}";
    }
}
