using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeddingWebsiteProject.Controllers
{
    public class MakeupController : Controller
    {
          // update hình ảnh trang điểm
        private readonly string imageInfoFileMakeup1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup1.json");
        private readonly string imageInfoFileMakeup2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup2.json");
        private readonly string imageInfoFileMakeup3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup3.json");
        private readonly string imageInfoFileMakeup4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup4.json");
        private readonly string imageInfoFileMakeup5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup5.json");
        private readonly string imageInfoFileMakeup6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup6.json");
        private readonly string imageInfoFileMakeup7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup7.json");
        private readonly string imageInfoFileMakeup8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup8.json");    
        private readonly ILogger<MakeupController> _logger;
        public MakeupController(ILogger<MakeupController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string? imageUrl = null;
            // Makeup 1
            if(System.IO.File.Exists(imageInfoFileMakeup1))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup1);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup1 = imageUrl ?? string.Empty;
            }  
            // Makeup 2
            if(System.IO.File.Exists(imageInfoFileMakeup2))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup2);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup2 = imageUrl ?? string.Empty;
            }
            // Makeup 3
            if(System.IO.File.Exists(imageInfoFileMakeup3))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup3);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup3 = imageUrl ?? string.Empty;
            }
            // Makeup 4
            if(System.IO.File.Exists(imageInfoFileMakeup4))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup4);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup4 = imageUrl ?? string.Empty;
            }
            // Makeup 5
            if(System.IO.File.Exists(imageInfoFileMakeup5))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup5);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup5= imageUrl ?? string.Empty;
            }
            // Makeup 6
            if(System.IO.File.Exists(imageInfoFileMakeup6))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup6);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup6 = imageUrl ?? string.Empty;
            }
            // Makeup 7
            if(System.IO.File.Exists(imageInfoFileMakeup7))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup7);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup7 = imageUrl ?? string.Empty;
            }
            // Makeup 8
            if(System.IO.File.Exists(imageInfoFileMakeup8))
            {
                var jsonData =  System.IO.File.ReadAllText(imageInfoFileMakeup8);
                imageUrl = JsonSerializer.Deserialize<string?>(jsonData);
                ViewBag.imageUrlMakeup8 = imageUrl ?? string.Empty;
            }
            return View("Index");

        }
    }
}