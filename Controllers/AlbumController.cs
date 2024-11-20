using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using WeddingWebsiteProject.Models;

namespace WeddingWebsiteProject.Controllers;


public class AlbumController : Controller{
    private readonly string imageInfoFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData.json");
    private readonly string imageInfoFilePath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData1.json");
    private readonly string imageInfoFilePath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData2.json");
    private readonly string imageInfoFilePath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData3.json");
    private readonly string imageInfoFilePath4= Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData4.json");
    private readonly string imageInfoFilePath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData5.json");
    private readonly string imageInfoFilePath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData6.json");
    private readonly string imageInfoFilePath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageData7.json");
    // Danh sách hình ảnh album 1
    private readonly string baseUploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum1");
    // Danh sách hình ảnh album 2
    private readonly string baseUploadPath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum2");
    // danh sách hỉnh ảnh album 3
    private readonly string baseUploadPath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum3");
    private readonly string baseUploadPath4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum4");
    private readonly string baseUploadPath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum5");
    private readonly string baseUploadPath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum6");
    private readonly string baseUploadPath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum7");
    private readonly string baseUploadPath8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum8");



    private readonly ILogger <AlbumController> _logger;
    public AlbumController (ILogger<AlbumController> logger)
    {
        _logger = logger;
    
    }

    [HttpGet]
    public IActionResult Index()
    {
        string? imageUrl = null; // Thay đổi ở đây: thêm dấu hỏi để cho phép null

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
        // Danh sách hình ảnh album1 
        // Đọc danh sách hình ảnh từ tệp JSON của Album 1
        var albumFilePath = Path.Combine(baseUploadPath, "Album1.json");
        List<string> imageListAlbum1 = new List<string>();
        if (System.IO.File.Exists(albumFilePath))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath);
            imageListAlbum1 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        }

        // Truyền danh sách hình ảnh vào View
        ViewBag.ImageListAlbum1 = imageListAlbum1;


        // Danh sách hình ảnh album 2
        // dọc danh sách hình ảnh từ tệp json của album 2

        var albumFilePath2 = Path.Combine(baseUploadPath,"Album2.json");
        List<string> imageListAlbum2 = new List<string>();
        if(System.IO.File.Exists(albumFilePath2))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath2);
            imageListAlbum2 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();

        } 
        ViewBag.ImageListAlbum2 = imageListAlbum2;

        // danh sách hình ảnh album 3
        // đọc danh sách hình ảnh từ tệp json cua album 3
        var albumFilePath3 = Path.Combine(baseUploadPath3, "Album3.json");
        List<string> imageListAlbum3 = new List<string>();
        if(System.IO.File.Exists(albumFilePath3)){
            var jsonData = System.IO.File.ReadAllText(albumFilePath3);
            imageListAlbum3 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();

        }

        ViewBag.ImageListAlbum3 = imageListAlbum3;

        // danh sách hình ảnh album 4
        // đọc danh sách hình ảnh từ JSON cua album4
        var albumFilePath4 = Path.Combine(baseUploadPath4, "Album4.json");
        List<string> imageListAlbum4 = new List<string>();
        if(System.IO.File.Exists(albumFilePath4))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath4);
            imageListAlbum4 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        }
        ViewBag.ImageListAlbum4 = imageListAlbum4;

        // danh sách hình ảnh album 5
        // đọc danh sách hình ảnh JSON của album 5

        var albumFilePath5 = Path.Combine(baseUploadPath5, "Album5.json");
        List<string> imageListAlbum5 = new List<string>();
        if(System.IO.File.Exists(baseUploadPath5))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath5);
            imageListAlbum5 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        }
        ViewBag.ImageListAlbum5 = imageListAlbum5;
        // danh sách hình ảnh album 6
        // đọc danh sách hình ảnh JSON của album 6
        var albumFilePath6 = Path.Combine(baseUploadPath6, "Album6.json");
        List<string> imageListAlbum6 = new List<string>();
        if(System.IO.File.Exists(baseUploadPath6))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath6);
            imageListAlbum6 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        }
        ViewBag.ImageListAlbum6 = imageListAlbum6;

        // danh sách hình ảnh album 7
        // đọc danh sách hình ảnh JSON của album 7
        var albumFilePath7 = Path.Combine(baseUploadPath7, "Album7.json");
        List<string> imageListAlbum7 = new List<string>();
        if(System.IO.File.Exists(baseUploadPath7))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath7);
            imageListAlbum7 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        } 
        ViewBag.ImageListAlbum7 = imageListAlbum7;
        // danh sách hình ảnh album 8
        // đọc danh sách hình ảnh JSON

        var albumFilePath8 = Path.Combine(baseUploadPath8, "Album8.json");
        List<string> imageListAlbum8 = new List<string>();
        if(System.IO.File.Exists(baseUploadPath8))
        {
            var jsonData = System.IO.File.ReadAllText(albumFilePath8);
            imageListAlbum8 =JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
        }
        ViewBag.ImageListAlbum8 = imageListAlbum8;
        return View();
    }

    public IActionResult showAlbum(string albumName)
    {
        // Hiển thị danh sách album 1
        var albumFilePath = Path.Combine(baseUploadPath, $"{albumName}.json");
        List<string> imageList = new List<string>();

        if (System.IO.File.Exists(albumFilePath))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // Hiển danh sách Album 2
        var albumFilePath2 = Path.Combine(baseUploadPath2,$"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath2))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath2);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            
        }

        // Hiển thị danh sách album 3
        var albumFilePath3 = Path.Combine(baseUploadPath3,$"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath3)){
            var existingData = System.IO.File.ReadAllText(albumFilePath3);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            
        }
        /// hiển thị danh sách album 4
        var albumFilePath4 = Path.Combine(baseUploadPath4, $"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath4))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath4);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // hiển thị danh sách album 5
        var albumFilePath5 = Path.Combine(baseUploadPath5, $"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath5))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath5);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // hiển thị danh sách album 6
        var albumFilepath6 = Path.Combine(baseUploadPath6, $"{albumName}.json");
        if(System.IO.File.Exists(albumFilepath6))
        {
            var existingData = System.IO.File.ReadAllText(albumFilepath6);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // hiển thị danh sách album 7

        var albumFilePath7 = Path.Combine(baseUploadPath7, $"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath7))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath7);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // hiển thị danh sách album 8
        var albumFilePath8 = Path.Combine(baseUploadPath8,$"{albumName}.json");
        if(System.IO.File.Exists(albumFilePath8))
        {
            var existingData = System.IO.File.ReadAllText(albumFilePath8);
            imageList = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
        }

        // Trả về partial view hiển thị danh sách hình ảnh 
        return View("_AlbumDetail", imageList);
    }
}