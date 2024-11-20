using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeddingWebsiteProject.Controllers
{

    public class DashBoardController : Controller
    {
        private readonly ILogger<DashBoardController> _logger;

        public DashBoardController(ILogger<DashBoardController> logger)
        {
                _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(){
            
            return View("Index");
        }
    }
}