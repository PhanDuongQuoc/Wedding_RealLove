using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
namespace WeddingWebsiteProject.Controllers
{
    public class WeddinggownpageController : Controller
    {
        // update hình ảnh cho trang Trang phục cưới
        private readonly string imageInfoFileWeddinggownpage1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown1.json");
        private readonly string imageInfoFileWeddinggownpage2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown2.json");
        private readonly string imageInfoFileWeddinggownpage3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown3.json");
        private readonly string imageInfoFileWeddinggownpage4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown4.json");

        private readonly ILogger<WeddinggownpageController> _logger;
        public WeddinggownpageController(ILogger<WeddinggownpageController> logger)
        {
            _logger = logger;
        
        }
        [HttpGet]
        public IActionResult Index(){
            // Trang trang phục cưới
            // trang phục cưới 1
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage1))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlWeddinggown1 = imageUrl;

                }catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }
            // trang phục cưới 2
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage2))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage2);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlWeddinggown2 = imageUrl;

                }catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }
            // trang phục cưới 3
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage3))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage3);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlWeddinggown3 = imageUrl;

                }catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }

            // trang phục cưới 4
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage4))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage4);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlWeddinggown4 = imageUrl;

                }catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }
            return View("Index");
        }
        
    }
}
