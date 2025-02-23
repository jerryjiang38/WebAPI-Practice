using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//10-目標：使用Dependency Injection調用CheckService
[Route("[controller]")]
public class CheckController
{
    private readonly CheckService _checkService;
    public CheckController(CheckService checkService)
    {
        _checkService = checkService;
    }
    [HttpPost("check")] //在/check/check取得
    public string Check()
    {
        //不需要var checkService = new CheckService();
        return _checkService.Check();
    }
}