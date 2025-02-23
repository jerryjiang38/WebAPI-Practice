using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI_Practice;
//9-目標：使用ModelState驗證
public class Product //通常一個檔案只放一個class
{
    [Required] //即使未設定[Required]，Properties/Language/NullableReferenceTypes的設定也會提示錯誤，可將它關閉
    public string? Name { get; set; } //?表示可為null
    [Range(1, 100, ErrorMessage = "嗨!Price must be between 1 and 100")] //ErrorMessage自訂錯誤訊息
    public decimal Price { get; set; } //即使傳入的是字串，也會自動轉換成decimal，因此須設定[Range]
    [MinLength(2)]
    [MaxLength(100)]
    public string Remark { get; set; }
}
[Route("[controller]")]
// [ApiController] 可直接取得失敗的狀況，但格式不佳
 public class ValidateController: ControllerBase
 {
    [HttpPost]
    public string AddProduct(Product product)
    {
        return ModelState.IsValid ? "OK" : $"Error: {GetValidationMessages()}";
    }
    [HttpPost("remove")]
    public string RemoveProduct([FromBody] Product product)
    {
        if(!ModelState.IsValid)
        {
            Response.StatusCode = 400;
            return $"Error: {GetValidationMessages()}";
        }
        return "OK";
    }
    private string GetValidationMessages()
    {
        return string.Join(", ", ModelState.Values
            .Select(x => string.Join(", ", x.Errors
                .Select(e => e.ErrorMessage)))); //Select遍歷每個元素，傳入暫時變數x，再Select遍歷每個元素，傳入暫時變數e
    }
}