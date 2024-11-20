using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
namespace WeddingWebsiteProject.Controllers
{

    public class VideoController: Controller
    {
        private readonly ILogger<VideoController> _logger;
         public VideoController(ILogger<VideoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

    }    
}