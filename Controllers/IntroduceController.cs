using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WeddingWebsiteProject.Models;

namespace WeddingWebsiteProject.Controllers;

public class IntroduceController : Controller
{
    // update hình ảnh cho trang Giới thiệu 
    private readonly string imageInfoFileIntroduce1 = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageDataIntroduce1.json");
    private readonly string imageInfoFileIntroduce2 = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageDataIntroduce2.json");
    private readonly string imageInfoFileIntroduce3 = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageDataIntroduce3.json");
    private readonly string imageInfoFileIntroduce4 = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageDataIntroduce4.json");

    private readonly ILogger<IntroduceController> _logger;
    public IntroduceController(ILogger<IntroduceController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Index(){
        string? imageUrl = null;
        if (System.IO.File.Exists(imageInfoFileIntroduce1))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce1);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.imageUrlIntroduce1 = imageUrl ?? string.Empty; // Gán giá trị mặc định nếu imageUrl là null
        }
         if (System.IO.File.Exists(imageInfoFileIntroduce2))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce2);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.imageUrlIntroduce2 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFileIntroduce3))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce3);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.imageUrlIntroduce3 = imageUrl ?? string.Empty;
        }


        if (System.IO.File.Exists(imageInfoFileIntroduce4))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce4);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.imageUrlIntroduce4 = imageUrl ?? string.Empty; // Gán giá trị mặc định nếu imageUrl là null
        }
        return View();
    }

}