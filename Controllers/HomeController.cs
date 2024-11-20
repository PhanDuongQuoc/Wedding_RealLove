using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WeddingWebsiteProject.Models;

namespace WeddingWebsiteProject.Controllers;

public class HomeController : Controller
{

    private readonly ILogger<HomeController> _logger;
    // Đường dẫn tới tệp JSON lưu hình ảnh Slider của Real Love
    private readonly string imageInfoFilePathSlider1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider1.json");
    private readonly string imageInfoFilePathSlider2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider2.json");
    private readonly string imageInfoFilePathSlider3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider3.json");
    // Album 
    private readonly string imageInfoFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData.json");
    private readonly string imageInfoFilePath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData1.json");
    private readonly string imageInfoFilePath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData2.json");
    private readonly string imageInfoFilePath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData3.json");
    private readonly string imageInfoFilePath4= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData4.json");
    private readonly string imageInfoFilePath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData5.json");
    private readonly string imageInfoFilePath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData6.json");
    private readonly string imageInfoFilePath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData7.json");
    //Chỉnh sửa ảnh đại diện phần services
    private readonly string imageInfoFilePath8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData8.json");
    private readonly string imageInfoFilePath9 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData9.json");
    private readonly string imageInfoFilePath10 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData10.json");



    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string? imageUrl = null; // Thay đổi ở đây: thêm dấu hỏi để cho phép null
        if (System.IO.File.Exists(imageInfoFilePathSlider1))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider1);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlSlider1 = imageUrl ?? string.Empty; // Gán giá trị mặc định nếu imageUrl là null
        }
         if (System.IO.File.Exists(imageInfoFilePathSlider2))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider2);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlSlider2 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePathSlider3))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider3);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlSlider3 = imageUrl ?? string.Empty;
        }


        if (System.IO.File.Exists(imageInfoFilePath))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrl = imageUrl ?? string.Empty; // Gán giá trị mặc định nếu imageUrl là null
        }
         if (System.IO.File.Exists(imageInfoFilePath1))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath1);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum2 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath2))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath2);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum3 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath3))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath3);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum4 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath4))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath4);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum5 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath5))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath5);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum6 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath6))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath6);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum7 = imageUrl ?? string.Empty;
        }
        if (System.IO.File.Exists(imageInfoFilePath7))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath7);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData); // Thay đổi ở đây: thêm dấu hỏi để cho phép null
            ViewBag.ImageUrlAlbum8 = imageUrl ?? string.Empty;
        }
        if(System.IO.File.Exists(imageInfoFilePath8))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath8);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
            ViewBag.ImageUrlAlbum9 = imageUrl ?? string.Empty;

        }
        if(System.IO.File.Exists(imageInfoFilePath9))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath9);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
            ViewBag.ImageUrlAlbum10 = imageUrl ?? string.Empty;
        }
        if(System.IO.File.Exists(imageInfoFilePath10))
        {
            var jsonData = System.IO.File.ReadAllText(imageInfoFilePath10);
            imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
            ViewBag.ImageUrlAlbum11 = imageUrl ?? string.Empty;

        }

        return View();
    }
    


    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
