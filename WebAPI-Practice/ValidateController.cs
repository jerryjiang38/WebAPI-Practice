using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace WebApplication1;
//9-目標：使用ModelState驗證
public class Product
{
    [Required]
    public string Name { get; set; }
    [Range(1, 100, ErrorMessage = "嗨!Price must be between 1 and 100")]
    public decimal Price { get; set; }
    [MinLength(2)]
    [MaxLength(100)]
    public string Remark { get; set; }
}
[Route("[controller]")]
 public class ValidateController: ControllerBase
 {
    [HttpPost]
    public string AddProduct(Product product)
    {
        return ModelState.IsValid ? "OK" : $"Error: {GetValidationMessages()}";
    }
    private string GetValidationMessages()
    {
        return string.Join(", ", ModelState.Values
            .Select(x => string.Join(", ", x.Errors
                .Select(e => e.ErrorMessage))));
    }
}