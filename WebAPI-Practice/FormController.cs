using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//5_2-目標：使用Form，傳入Form名稱
public class Form
{
    public string name { get; set; }
}
[Route("[controller]")]
public class FormController
{
    [HttpGet("get")] //在/form/get取得 //Body/x-www-form-unlencoded 輸入name=Vern
    public string Get([FromForm] Form form)
    {
        return $"name={form.name}";
    }
}