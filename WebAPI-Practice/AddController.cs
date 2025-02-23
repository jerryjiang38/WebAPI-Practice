using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//4-目標：使用Parameters，回傳兩個數字相加的結果
public class AddController
{
    [HttpGet("add")] //在/add?a=1&b=2取得3
    public int Get(int a, int b)
    {
        return a + b;
    }
}