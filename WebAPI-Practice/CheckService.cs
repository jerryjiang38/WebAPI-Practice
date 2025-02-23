namespace WebAPI_Practice;
//使用 DI：Controller 更簡潔，且服務可從依賴注入容器取得，方便進行單元測試、解耦合與替換實作。
//不使用 DI：Controller 需要自己 new 服務，會與服務的實作耦合，不易測試，也不便於未來的擴展與維護。
public class CheckService
{
    public string Check()
    {
        return "Success";
    }
}