using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//2-目標：建立一個OrderController，提供GetAllOrder、Add、SetNumber、RemoveItem函數
[Route("[controller]/[action]")] //("[Controller的名稱]/[函數名稱]")
public class OrderController
{
    [HttpGet]
    public string GetAllOrder()
    {
        return "All Order";
    }

    [HttpPost]
    public string Add()
    {
        return "add";
    }

    [HttpPut("{orderId}/item/{itemId}/number/{number}")]
    public string SetNumber(int orderId, int itemId, int number)
    {
        return $"set number {number} for item {itemId} in order {orderId}";
    }
    [HttpDelete("{orderId}/item/{itemId}")]
    public string SetNumber(int orderId, int itemId)
    {
        return $"remove item {itemId} in order {orderId}";
    }
}