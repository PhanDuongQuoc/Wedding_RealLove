using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.CodeAnalysis;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace WeddingWebsiteProject.Controllers
{
    public class UploadController : Controller
    {
        // Đường dẫn tới tệp JSON lưu hình ảnh Slider của Real Love
        private readonly string imageInfoFilePathSlider1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider1.json");
        private readonly string imageInfoFilePathSlider2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider2.json");
        private readonly string imageInfoFilePathSlider3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataSlider3.json");
        // Đường dẫn tới tệp JSON lưu thông tin ảnh Album 1 2 3 4 5 6 7 8 9 10 11
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
        // update hình ảnh cho trang Giới thiệu 
        private readonly string imageInfoFileIntroduce1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataIntroduce1.json");
        private readonly string imageInfoFileIntroduce2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataIntroduce2.json");
        private readonly string imageInfoFileIntroduce3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataIntroduce3.json");
        private readonly string imageInfoFileIntroduce4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataIntroduce4.json");
        // update hình ảnh cho trang Trang phục cưới
        private readonly string imageInfoFileWeddinggownpage1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown1.json");
        private readonly string imageInfoFileWeddinggownpage2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown2.json");
        private readonly string imageInfoFileWeddinggownpage3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown3.json");
        private readonly string imageInfoFileWeddinggownpage4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataWeddinggown4.json");
        // update hình ảnh trang điểm
        private readonly string imageInfoFileMakeup1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup1.json");
        private readonly string imageInfoFileMakeup2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup2.json");
        private readonly string imageInfoFileMakeup3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup3.json");
        private readonly string imageInfoFileMakeup4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup4.json");
        private readonly string imageInfoFileMakeup5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup5.json");
        private readonly string imageInfoFileMakeup6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup6.json");
        private readonly string imageInfoFileMakeup7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup7.json");
        private readonly string imageInfoFileMakeup8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageDataMakeup8.json"); 
        // Upload chi tiết hình ảnh album1 
        private readonly string baseUploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum1");
        private readonly string baseUploadPath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum2");
        private readonly string baseUploadPath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum3");
        private readonly string baseUploadPath4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum4");
        private readonly string baseUploadPath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum5");
        private readonly string baseUploadPath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum6");
        private readonly string baseUploadPath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum7");
        private readonly string baseUploadPath8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesAlbum8");


        // danh sách hình ảnh makeup
        private readonly string baseUploadMakeupPath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup1" );
        private readonly string baseUploadMakeupPath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup2" );
        private readonly string baseUploadMakeupPath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup3" );
        private readonly string baseUploadMakeupPath4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup4" );
        private readonly string baseUploadMakeupPath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup5" );
        private readonly string baseUploadMakeupPath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup6" );
        private readonly string baseUploadMakeupPath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup7" );
        private readonly string baseUploadMakeupPath8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesMakeup8" );

        // danh sách hình ảnh trang phục wedding gown page 
        private readonly string baseUploadGownPagePath1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage1" );
        private readonly string baseUploadGownPagePath2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage2" );
        private readonly string baseUploadGownPagePath3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage3" );
        private readonly string baseUploadGownPagePath4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage4" );
        private readonly string baseUploadGownPagePath5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage5" );
        private readonly string baseUploadGownPagePath6 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage6" );
        private readonly string baseUploadGownPagePath7 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage7" );
        private readonly string baseUploadGownPagePath8 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imagesGownPage8" );


        private readonly ILogger<UploadController> _logger;

        public UploadController(ILogger<UploadController> logger)
        {
            _logger = logger;
        }

       [HttpGet]
        public IActionResult Index()
        {
            if (System.IO.File.Exists(imageInfoFilePathSlider1))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlSlider1 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Slider 1");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePathSlider2))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider2);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlSlider2 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Slider 2");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePathSlider3))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider3);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlSlider3 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Slider 3");
                }
            }

            if (System.IO.File.Exists(imageInfoFilePath))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrl = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 1");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath1))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum2 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 2");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath2))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath2);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum3 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 3");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath3))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath3);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum4 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 4");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath4))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath4);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum5 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 5");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath5))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath5);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum6 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 6");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath6))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath6);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum7 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 7");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath7))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath7);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum8 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 8");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath8))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath8);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum9 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 9");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath9))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath9);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum10 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 10");
                }
            }
            if (System.IO.File.Exists(imageInfoFilePath10))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath10);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.ImageUrlAlbum11 = imageUrl;
                }
                catch (JsonException ex)
                {
                    _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }


            // Trang Giới Thiệu 
            //  image introduce 1
            if(System.IO.File.Exists(imageInfoFileIntroduce1))
            {
                try{
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlIntroduce1 = imageUrl;
                }
                catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }

            //  image introduce 2
            if(System.IO.File.Exists(imageInfoFileIntroduce2))
            {
                try{
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce2);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlIntroduce2 = imageUrl;
                }
                catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }
            //  image introduce 3
            if(System.IO.File.Exists(imageInfoFileIntroduce3))
            {
                try{
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce3);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlIntroduce3 = imageUrl;
                }
                catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }

            //  image introduce 4
            if(System.IO.File.Exists(imageInfoFileIntroduce4))
            {
                try{
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce4);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlIntroduce4 = imageUrl;
                }
                catch(JsonException ex)
                {
                     _logger.LogError(ex, "Error reading JSON for Album 11");
                }
            }
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

            // Trang Makeup
            // Makeup 1
            if(System.IO.File.Exists(imageInfoFileMakeup1))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup1 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }
            // Makeup 2
            
            if(System.IO.File.Exists(imageInfoFileMakeup2))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup2);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup2 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }
            // Makeup 3
            
            if(System.IO.File.Exists(imageInfoFileMakeup3))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup3);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup3 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }

            // Makeup 4
            
            if(System.IO.File.Exists(imageInfoFileMakeup4))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup4);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup4 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }
            // Makeup 5
            
            if(System.IO.File.Exists(imageInfoFileMakeup5))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup5);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup5 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }

            // Makeup 6
            
            if(System.IO.File.Exists(imageInfoFileMakeup6))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup6);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup6 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }

            /// Makeup 7
            

            
            if(System.IO.File.Exists(imageInfoFileMakeup7))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup7);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup7 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }


            }

            // Makeup 8
            
            if(System.IO.File.Exists(imageInfoFileMakeup8))
            {
                try
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup8);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                    ViewBag.imageUrlMakeup8 = imageUrl;

                }
                catch(JsonException ex)
                {
                    _logger.LogError(ex,"Error reading JSON");

                }



            }

            // Đọc danh sách hình ảnh từ tệp JSON của Album 1
            var albumFilePath = Path.Combine(baseUploadPath, "Album1.json");
            List<string> imageListAlbum1 = new List<string>();
            if (System.IO.File.Exists(albumFilePath))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum1 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            // Truyền danh sách hình ảnh vào View Album 1
            ViewBag.ImageListAlbum1 = imageListAlbum1;

            //Đọc danh sách hình ảnh từ tệp JSON của Album 2

            var albumFilePath2 = Path.Combine(baseUploadPath2,"Album2.json");
            List<string> imageListAlbum2 = new List<string>();
            if(System.IO.File.Exists(albumFilePath2)){
                var jsonData = System.IO.File.ReadAllText(albumFilePath2);
                imageListAlbum2 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }
            // truyền hình ảnh vào view album 2
            ViewBag.ImageListAlbum2 = imageListAlbum2; 

            // Đọc danh sách hình ảnh từ tệp JSON Album 3

            var albumFilePath3 = Path.Combine(baseUploadPath3,"Album3.json");
            List<string> imageListAlbum3 = new List<string>();
            if(System.IO.File.Exists(albumFilePath3))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath3);
                imageListAlbum3 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();

            }
            ViewBag.ImageListAlbum3 = imageListAlbum3;

            //Đọc danh sách hình ảnh từ tệp JSON Album 4
            var albumFilePath4 = Path.Combine(baseUploadPath4,"Album4.json");
            List<string> imageListAlbum4 = new List<string>();
            if(System.IO.File.Exists(albumFilePath4))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath4);
                imageListAlbum4 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListAlbum4 = imageListAlbum4;

            //Đọc danh sách hình ảnh từ tệp JSON Album 5
            var albumFilePath5 = Path.Combine(baseUploadPath5,"Album5.json");
            List<string> imageListAlbum5 = new List<string>();
            if(System.IO.File.Exists(albumFilePath5))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath5);
                imageListAlbum5 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListAlbum5 = imageListAlbum5;

            //Đọc danh sách hình ảnh từ tệp JSON Album 6
            var albumFilePath6 = Path.Combine(baseUploadPath6,"Album6.json");
            List<string> imageListAlbum6 = new List<string>();
            if(System.IO.File.Exists(albumFilePath6))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath6);
                imageListAlbum6 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListAlbum6 = imageListAlbum6;

            //Đọc danh sách hình ảnh từ tệp JSON Album 7
            var albumFilePath7 = Path.Combine(baseUploadPath7,"Album7.json");
            List<string> imageListAlbum7 = new List<string>();
            if(System.IO.File.Exists(albumFilePath7))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath7);
                imageListAlbum7 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListAlbum7 = imageListAlbum7;

            //Đọc danh sách hình ảnh từ tệp JSON Album 8
            var albumFilePath8 = Path.Combine(baseUploadPath8,"Album8.json");
            List<string> imageListAlbum8 = new List<string>();
            if(System.IO.File.Exists(albumFilePath8))
            {
                var jsonData = System.IO.File.ReadAllText(albumFilePath8);
                imageListAlbum8 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListAlbum8 = imageListAlbum8;
            // đọc danh sách hình ảnh từ tệp JSON của trang Makeup
            // đọc danh sách hình ảnh Makeup1
            var makeupFilePath1 = Path.Combine(baseUploadMakeupPath1, "Makeup1.json");
            List<string> imageListMakeup1 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath1)){
                var jsonData = System.IO.File.ReadAllText(makeupFilePath1);
                imageListMakeup1 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListMakeup1 = imageListMakeup1;

            // đọc danh sách hình ảnh makeup 2

            var makeupFilePath2 = Path.Combine(baseUploadMakeupPath2, "Makeup2.json");
            List<string> imageListMakeup2 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath2))
            {
                var jsonData = System.IO.File.ReadAllText(makeupFilePath2);
                imageListMakeup2 = JsonSerializer.Deserialize<List<string>>(jsonData)?? new List<string>();
            }
            ViewBag.ImageListMakeup2 = imageListMakeup2;
            // đọc dnah sách hình ảnh makeup3
            var makeupFilePath3 = Path.Combine(baseUploadMakeupPath3, "Makeup3.json");
            List<string> imageListMakeup3 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath3))
            {
                var jsonData = System.IO.File.ReadAllText(makeupFilePath3);
                imageListMakeup3 = JsonSerializer.Deserialize<List<string>>(jsonData)?? new List<string>();
            }

            ViewBag.ImageListMakeup3 = imageListMakeup3;

            // đọc danh sách hình ảnh makeup4

            var makeupFilePath4 = Path.Combine(baseUploadMakeupPath4, "Makeup3.json");
            List<string> imageListMakeup4 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath4)){
                var jsonData = System.IO.File.ReadAllText(makeupFilePath4);
                imageListMakeup4 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>(); 
            } 

            ViewBag.ImageListMakeup4 = imageListMakeup4;

            // đọc danh sách hình ảnh makeup 5

            var makeupFilePath5 = Path.Combine(baseUploadMakeupPath5, "Makeup5.json");
            List<string> imageListMakeup5 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath5)){
                var jsonData = System.IO.File.ReadAllText(makeupFilePath5);
                imageListMakeup5 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();

            }
            ViewBag.ImageListMakeup5 =imageListMakeup5;



            // đọc danh sách hình ảnh makeup 6


            var makeupFilePath6 = Path.Combine(baseUploadMakeupPath6, "Makeup6.json");
            List<string> imageListMakeup6 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath6))
            {
                var jsonData = System.IO.File.ReadAllText(makeupFilePath6);
                imageListMakeup6 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }
            ViewBag.ImageListMakeup6 = imageListMakeup6;


            // đọc danh sách hình ảnh makeup 7

            var makeupFilePath7 = Path.Combine(baseUploadMakeupPath7, "Makeup7.json");
            List<string> imageListMakeup7 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath7)){
                var jsonData = System.IO.File.ReadAllText(makeupFilePath7);
                 imageListMakeup7 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListMakeup7 = imageListAlbum7;


            // đọc danh sách hình ảnh makeup 8

            var makeupFilePath8 = Path.Combine(baseUploadMakeupPath8, "Makeup8.json");
            List<string> imageListMakeup8 = new List<string>();
            if(System.IO.File.Exists(makeupFilePath8)){
                var jsonData = System.IO.File.ReadAllText(makeupFilePath8);
                imageListMakeup8 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }
            ViewBag.ImageListMakeup8 =imageListMakeup8;
            // danh sách wedding gown page 
            // danh sách wedding gown page 1
            var gownpageFilePath1 = Path.Combine(baseUploadGownPagePath1, "GownPage1.json");
            List<string> imageListGownPage1 = new List<string>();
            if(System.IO.File.Exists(gownpageFilePath1)){
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath1);
                imageListGownPage1 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListGownPage1 = imageListGownPage1;

            // danh sách wedding gown page 2
            var gownpageFilePath2 = Path.Combine(baseUploadGownPagePath2, "GownPage2.json");
            List<string> imageListGownPage2 = new List<string>();
            if(System.IO.File.Exists(gownpageFilePath2)){
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath2);
                imageListGownPage2 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            } 

            ViewBag.ImageListGownPage2 = imageListGownPage2;

            // danh sách wedding gown page 3

            var gownpageFilePath3 = Path.Combine(baseUploadGownPagePath3, "GownPage3.json");
            List<string> imageListGownPage3 = new List<string>();
            if(System.IO.File.Exists(gownpageFilePath3))
            {
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath3);
                imageListGownPage3 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();  
            } 
            ViewBag.ImageListGownPage3 = imageListGownPage3;

            // danh  sách hình ảnh wedding gown page 4

            var gownpageFilePath4 = Path.Combine(baseUploadGownPagePath4, "GownPage4.json");
            List<string> imageListGownPage4 = new List<string>();
            if(System.IO.File.Exists( gownpageFilePath4)){
                var jsonData = System.IO.File.ReadAllText( gownpageFilePath4);
                imageListGownPage4 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
            }

            ViewBag.ImageListGownPage4 = imageListGownPage4;
            // danh sách hình ảnh wedding gown page 5
            var gownpageFilePath5 = Path.Combine(baseUploadGownPagePath5,"GownPage5.json");
            List<string> imageListGownPage5 =  new List<string>();
            if(System.IO.File.Exists(gownpageFilePath5)){
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath5);
                imageListGownPage5 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();

            }
              ViewBag.ImageListGownPage5 = imageListGownPage5;

              // danh sách hình ảnh wedding gown page 6 
              var gownpageFilePath6 = Path.Combine(baseUploadGownPagePath6, "GownPage6.json");
              List<string> imageListGownPage6 = new List<string>();
              if(System.IO.File.Exists(gownpageFilePath6)){
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath6);
                imageListGownPage6 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
              }

              ViewBag.ImageListGownPage6 = imageListGownPage6;

              // danh sách hình ảnh wedding gown page 7

              var gownpageFilePath7 = Path.Combine(baseUploadGownPagePath7, "GownPage7.json");
              List<string> imageListGownPage7 = new List<string>();
              if(System.IO.File.Exists(gownpageFilePath7)){
                 var jsonData = System.IO.File.ReadAllText(gownpageFilePath7);
                 imageListGownPage7 = JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();   
              }

              ViewBag.ImageListGownPage7 = imageListGownPage7;
              // danh sách hình ảnh wedding gown page8 

              var gownpageFilePath8 = Path.Combine(baseUploadGownPagePath8, "GownPage8.json");
              List<string> imageListGownPage8 = new List<string>();
              if(System.IO.File.Exists(gownpageFilePath8)){
                var jsonData = System.IO.File.ReadAllText(gownpageFilePath8);
                imageListGownPage8= JsonSerializer.Deserialize<List<string>>(jsonData) ?? new List<string>();
              }

              ViewBag.ImageListGownPage8 = imageInfoFileMakeup8;
            return View();
        }
    

        // Upload Slider 1 cho Real Love 
        [HttpPost]
        public async Task<IActionResult> UploadSlider1()
        {
            // Kiểm tra nếu không có tệp nào được tải lên
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file =  Request.Form.Files[0];
            if(file !=  null && file.Length > 0){
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadSlider1", fileName);
                using(var stream = new FileStream(filePath,FileMode.Create)){
                    await file.CopyToAsync(stream);
                } 
                var imageUrl = $"/uploads/imageUploadSlider1/{fileName}";
                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePathSlider1, jsonData);

                ViewBag.ImageUrlSlider1 = imageUrl;
            }
            else
            {
                ViewBag.MessageSlider1 = "Please select a file for Album 1.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index"); 
        }

         // Upload Slider 2 cho Real Love 
        [HttpPost]
        public async Task<IActionResult> UploadSlider2()
        {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file =  Request.Form.Files[0];
            if(file !=  null && file.Length > 0){
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadSlider2", fileName);
                using(var stream = new FileStream(filePath,FileMode.Create)){
                    await file.CopyToAsync(stream);
                } 
                var imageUrl = $"/uploads/imageUploadSlider2/{fileName}";
                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePathSlider2, jsonData);

                ViewBag.ImageUrlSlider2 = imageUrl;
            }
            else
            {
                ViewBag.MessageSlider2= "Please select a file for Album 1.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index"); 
        }

         // Upload Slider 3 cho Real Love 
        [HttpPost]
        public async Task<IActionResult> UploadSlider3()
        {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file =  Request.Form.Files[0];
            if(file !=  null && file.Length > 0){
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadSlider3", fileName);
                using(var stream = new FileStream(filePath,FileMode.Create)){
                    await file.CopyToAsync(stream);
                } 
                var imageUrl = $"/uploads/imageUploadSlider3/{fileName}";
                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePathSlider3, jsonData);

                ViewBag.ImageUrlSlider3 = imageUrl;
            }
            else
            {
                ViewBag.MessageSlider3 = "Please select a file for Album 1.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index"); 
        }

        // Upload ảnh cho Album 1
        [HttpPost]
        public async Task<IActionResult> UploadImage()
        {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage", fileName);

                // Lưu file ảnh vào thư mục server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var imageUrl = $"/uploads/imageUploadImage/{fileName}";

                // Ghi đường dẫn ảnh vào tệp JSON của Album 1
                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath, jsonData);

                ViewBag.ImageUrl = imageUrl;
            }
            else
            {
                ViewBag.MessageAlbum1 = "Please select a file for Album 1.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }

        // Upload ảnh cho Album 2
        [HttpPost]
        public async Task<IActionResult> UploadImage1()
        {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage1", fileName);

                // Lưu file ảnh vào thư mục server
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                var imageUrl = $"/uploads/imageUploadImage1/{fileName}";

                // Ghi đường dẫn ảnh vào tệp JSON của Album 2
                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath1, jsonData);

                ViewBag.ImageUrlAlbum2 = imageUrl;
            }
            else
            {
                ViewBag.MessageAlbum2 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }

        // Upload Album 3

        public async Task<IActionResult> UploadImage2() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage2", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage2/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath2, jsonData);

                ViewBag.ImageUrlAlbum3 = imageUrl;
            }
            else
            {
                ViewBag.MessageAlbum3 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");   
        }   

        // Upload Album 4

        public async Task<IActionResult> UploadImage3() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage3", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage3/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath3, jsonData);

                ViewBag.ImageUrlAlbum4 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum4 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }

        // Upload Album 5

        public async Task<IActionResult> UploadImage4() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage4", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage4/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath4, jsonData);

                ViewBag.ImageUrlAlbum5 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum5 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }
        // Upload Album 6

        public async Task<IActionResult> UploadImage5() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage5", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage5/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath5, jsonData);

                ViewBag.ImageUrlAlbum6 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum6 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }

        // Upload Album 7

        public async Task<IActionResult> UploadImage6() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage6", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage6/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath6, jsonData);

                ViewBag.ImageUrlAlbum7 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum7 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }
        // Upload Album 8

        public async Task<IActionResult> UploadImage7() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage7", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage7/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath7, jsonData);

                ViewBag.ImageUrlAlbum8 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum8 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        }      


        //Chỉnh sửa ảnh đại diện phần services
        public async Task<IActionResult> UploadImage8() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage8", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage8/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath8, jsonData);

                ViewBag.ImageUrlAlbum9 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum9 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        } 

         public async Task<IActionResult> UploadImage9() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage9", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage9/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath9, jsonData);

                ViewBag.ImageUrlAlbum10 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum10 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        } 

         public async Task<IActionResult> UploadImage10() {
            if (Request.Form.Files.Count == 0)
            {
                LoadAlbumImages(); // Tải lại ảnh để hiển thị chính xác
                return View("Index"); // Trả về View với thông báo lỗi
            }
            var file = Request.Form.Files[0];
            if(file !=null && file.Length > 0 ) {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads/imageUploadImage10", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImage10/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFilePath10, jsonData);

                ViewBag.ImageUrlAlbum11 = imageUrl;
            }   
            else
            {
                ViewBag.MessageAlbum11 = "Please select a file for Album 2.";
            }
            
            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return View("Index");
        } 
        

        // Upload Image Introduce
        // Image 1  

        public async Task<IActionResult> UploadImageIntroduce1()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageIntroduce1", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageIntroduce1/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileIntroduce1, jsonData);

                ViewBag.imageUrlIntroduce1 = imageUrl;
            }
             else
            {
                ViewBag.MessageimageIntroduce1 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }

        // Image 2

        public async Task<IActionResult> UploadImageIntroduce2()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageIntroduce2", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageIntroduce2/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileIntroduce2, jsonData);

                ViewBag.imageUrlIntroduce2 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageIntroduce2 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }


        // Image 3

        public async Task<IActionResult> UploadImageIntroduce3()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageIntroduce3", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageIntroduce3/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileIntroduce3, jsonData);

                ViewBag.imageUrlIntroduce3 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageIntroduce3 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }

        // Image 4

        public async Task<IActionResult> UploadImageIntroduce4()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageIntroduce4", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageIntroduce4/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileIntroduce4, jsonData);

                ViewBag.imageUrlIntroduce4 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageIntroduce4 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }


        // Trang Phục cưới
        // Trang phục cưới 1
        public async Task<IActionResult> UploadImageWeddinggown1()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageWeddinggown1", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageWeddinggown1/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileWeddinggownpage1, jsonData);

                ViewBag.imageUrlWeddinggown1 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageWeddinggown1 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        
        // Trang phục cưới 2
        public async Task<IActionResult> UploadImageWeddinggown2()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageWeddinggown2", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageWeddinggown2/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileWeddinggownpage2, jsonData);

                ViewBag.imageUrlWeddinggown2 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageWeddinggown2 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }

        // Trang phục cưởi 3

        public async Task<IActionResult> UploadImageWeddinggown3()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageWeddinggown3", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageWeddinggown3/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileWeddinggownpage3, jsonData);

                ViewBag.imageUrlWeddinggown3 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageWeddinggown3 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // TRang phục cưới 4
        public async Task<IActionResult> UploadImageWeddinggown4()
        {
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageWeddinggown4", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageWeddinggown4/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileWeddinggownpage4, jsonData);

                ViewBag.imageUrlWeddinggown4 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageWeddinggown4 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }

        // Upload Trang Makeup
        // Makeup 1
        public async Task<IActionResult> UploadImageMakeup1()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup1", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup1/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup1, jsonData);

                ViewBag.imageUrlMakeup1 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup1 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 2
        public async Task<IActionResult> UploadImageMakeup2()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup2", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup2/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup2, jsonData);

                ViewBag.imageUrlMakeup2 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup2 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 3
        public async Task<IActionResult> UploadImageMakeup3()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup3", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup3/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup3, jsonData);

                ViewBag.imageUrlMakeup3 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup3 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 4
        public async Task<IActionResult> UploadImageMakeup4()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup4", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup4/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup4, jsonData);

                ViewBag.imageUrlMakeup4 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup4 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 5
        public async Task<IActionResult> UploadImageMakeup5()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup5", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup5/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup5, jsonData);

                ViewBag.imageUrlMakeup5 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup5 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 6

        public async Task<IActionResult> UploadImageMakeup6()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup6", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup6/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup6, jsonData);

                ViewBag.imageUrlMakeup6 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup6 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 7

        public async Task<IActionResult> UploadImageMakeup7()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup7", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup7/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup7, jsonData);

                ViewBag.imageUrlMakeup7 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup7 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        // Makeup 8
        public async Task<IActionResult> UploadImageMakeup8()
        {
            
            if(Request.Form.Files.Count == 0){
                LoadAlbumImages();
                return View("Index");

            }
            var file = Request.Form.Files[0];
            if(file != null && file.Length >0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/uploads/imageUploadImageMakeup8", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create)){
                    await file.CopyToAsync(stream);
                }
                var imageUrl =  $"/uploads/imageUploadImageMakeup8/{fileName}";

                var jsonData = JsonSerializer.Serialize(imageUrl);
                System.IO.File.WriteAllText(imageInfoFileMakeup8, jsonData);

                ViewBag.imageUrlMakeup8 = imageUrl;
            }
            else
            {
                ViewBag.MessageimageMakeup8 = "Please select a file for Album 2.";
            }
            LoadAlbumImages();
            return View("Index");
        }
        

        // Xóa ảnh của Album 1
        [HttpPost]
        public IActionResult DeleteImage()
        {
            try
            {
                if (System.IO.File.Exists(imageInfoFilePath))
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", imageUrl.TrimStart('/'));

                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    System.IO.File.Delete(imageInfoFilePath);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while deleting image.");
                ViewBag.MessageAlbum1 = "An error occurred while deleting the image.";
            }

            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return RedirectToAction("Index");
        }

        // Xóa ảnh của Album 2
        [HttpPost]
        public IActionResult DeleteImage1()
        {
            try
            {
                if (System.IO.File.Exists(imageInfoFilePath1))
                {
                    var jsonData = System.IO.File.ReadAllText(imageInfoFilePath1);
                    var imageUrl = JsonSerializer.Deserialize<string>(jsonData);

                    if (!string.IsNullOrEmpty(imageUrl))
                    {
                        var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", imageUrl.TrimStart('/'));

                        if (System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }
                    }

                    System.IO.File.Delete(imageInfoFilePath1);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while deleting image.");
                ViewBag.MessageAlbum2 = "An error occurred while deleting the image.";
            }

            // Hiển thị lại Index với dữ liệu cho cả hai album
            LoadAlbumImages();
            return RedirectToAction("Index");
        }





        [HttpPost]
        public IActionResult UploadAlbum1(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum1 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum1/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath, "Album1.json");
            List<string> imageListAlbum1;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum1 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum1 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum1.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum1);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // Upaload danh sách hình ảnh cho Album 2
        [HttpPost]
        public IActionResult UploadAlbum2(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum2 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath2, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum2/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath2, "Album2.json");
            List<string> imageListAlbum2;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum2 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum2 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum2.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum2);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // Upaload danh sách hình ảnh cho Album 3
        [HttpPost]
        public IActionResult UploadAlbum3(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum3 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath3, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum3/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath3, "Album3.json");
            List<string> imageListAlbum3;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum3 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum3 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum3.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum3);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }



         // Upaload danh sách hình ảnh cho Album 4
        [HttpPost]
        public IActionResult UploadAlbum4(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum4 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath4, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum4/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath4, "Album4.json");
            List<string> imageListAlbum4;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum4 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum4 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum4.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum4);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }


          // Upaload danh sách hình ảnh cho Album 5
        [HttpPost]
        public IActionResult UploadAlbum5(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum5 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath5, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum5/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath5, "Album5.json");
            List<string> imageListAlbum5;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum5 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum5 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum5.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum5);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

         // Upaload danh sách hình ảnh cho Album 6
        [HttpPost]
        public IActionResult UploadAlbum6(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum6 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath6, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum6/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath6, "Album6.json");
            List<string> imageListAlbum6;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum6 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum6 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum6.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum6);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

         // Upaload danh sách hình ảnh cho Album 7
        [HttpPost]
        public IActionResult UploadAlbum7(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum8 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath7, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum7/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath7, "Album7.json");
            List<string> imageListAlbum7;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum7 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum7 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum7.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum7);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

         // Upaload danh sách hình ảnh cho Album 8
        [HttpPost]
        public IActionResult UploadAlbum8(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageAlbum8 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadPath8, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesAlbum8/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadPath8, "Album8.json");
            List<string> imageListAlbum8;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListAlbum8 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListAlbum8 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListAlbum8.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListAlbum8);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

         // Upaload danh sách hình ảnh cho Makeup 1
        [HttpPost]
        public IActionResult UploadMakeup1(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup1 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath1, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup1/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath1,"Makeup1.json");
            List<string> imageListMakeup1;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup1 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup1 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup1.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 1
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup1);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // Upaload danh sách hình ảnh cho Makeup 1
        [HttpPost]
        public IActionResult UploadMakeup2(List<IFormFile> file)
        {
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup2 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath2, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup2/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath2,"Makeup2.json");
            List<string> imageListMakeup2;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup2 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup2 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup2.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 2
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup2);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload hình ảnh danh sách 3
        [HttpPost]
        public IActionResult UploadMakeup3(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup3 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath3, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup3/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath3,"Makeup3.json");
            List<string> imageListMakeup3;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup3 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup3 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup3.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup3);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upoad danh sách hình ảnh 4

        [HttpPost]
        public IActionResult UploadMakeup4(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup4 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath4, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup4/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath4,"Makeup4.json");
            List<string> imageListMakeup4;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup4 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup4 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup4.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 4
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup4);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload hình ảnh danh sách 5

        [HttpPost]
        public IActionResult UploadMakeup5(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup5 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath5, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup5/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath5,"Makeup5.json");
            List<string> imageListMakeup5;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup5 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup5 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup5.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup5);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload hình ảnh danh sách 6
        [HttpPost]
        public IActionResult UploadMakeup6(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup6 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath6, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup6/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath6,"Makeup6.json");
            List<string> imageListMakeup6;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup6 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup6 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup6.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup6);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload hình ảnh danh sách 7
        [HttpPost]
        public IActionResult UploadMakeup7(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup7 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath7, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup7/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath7,"Makeup7.json");
            List<string> imageListMakeup7;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup7 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup7 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup7.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup7);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload hình ảnh danh sách 8

        [HttpPost]
        public IActionResult UploadMakeup8(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageMakeup8 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadMakeupPath8, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesMakeup8/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadMakeupPath8,"Makeup8.json");
            List<string> imageListMakeup8;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListMakeup8 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListMakeup8 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListMakeup8.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListMakeup8);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh trang trang phục cưới 
        // upload danh sách hình ảnh GownPage 1
        [HttpPost]
        public IActionResult UploadGownPage1(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage1 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath1, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage1/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath1,"GownPage1.json");
            List<string> imageListGownPage1;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage1 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage1 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage1.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage1);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 2
        [HttpPost]
        public IActionResult UploadGownPage2(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage2 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath2, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage2/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath2,"GownPage2.json");
            List<string> imageListGownPage2;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage2 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage2 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage2.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage2);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 3
        [HttpPost]
        public IActionResult UploadGownPage3(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage3 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath3, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage3/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath3,"GownPage3.json");
            List<string> imageListGownPage3;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage3 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage3 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage3.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage3);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 4
        [HttpPost]
        public IActionResult UploadGownPage4(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage4 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath4, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage4/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath2,"GownPage4.json");
            List<string> imageListGownPage4;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage4 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage4 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage4.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage4);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 5
        [HttpPost]
        public IActionResult UploadGownPage5(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage5 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath5, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage5/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath5,"GownPage5.json");
            List<string> imageListGownPage5;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage5 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage5 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage5.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage5);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 6
        [HttpPost]
        public IActionResult UploadGownPage6(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage6 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath6, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage6/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath6,"GownPage6.json");
            List<string> imageListGownPage6;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage6 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage6 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage6.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage6);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 7
        [HttpPost]
        public IActionResult UploadGownPage7(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage7 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath7, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage7/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath7,"GownPage7.json");
            List<string> imageListGownPage7;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage7 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage7 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage7.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage7);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }

        // upload danh sách hình ảnh GownPage 8
        [HttpPost]
        public IActionResult UploadGownPage8(List<IFormFile> file){
            if (file.Count == 0)
            {
                ViewBag.MessageGownPage8 = "No files selected.";
                return RedirectToAction("Index");
            }

            // Lưu trữ các ảnh đã upload
            var uploadedImages = new List<string>();

            foreach (var img in file)
            {
                var fileName = Path.GetFileName(img.FileName);
                var filePath = Path.Combine(baseUploadGownPagePath8, fileName);

                // Lưu ảnh vào thư mục
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    img.CopyTo(stream);
                }

                // Lưu đường dẫn ảnh
                var imageUrl = $"/uploads/imagesGownPage8/{fileName}";
                uploadedImages.Add(imageUrl);
            }

            // Cập nhật danh sách hình ảnh
            var albumFilePath = Path.Combine(baseUploadGownPagePath8,"GownPage8.json");
            List<string> imageListGownPage8;
            if (System.IO.File.Exists(albumFilePath))
            {
                var existingData = System.IO.File.ReadAllText(albumFilePath);
                imageListGownPage8 = JsonSerializer.Deserialize<List<string>>(existingData) ?? new List<string>();
            }
            else
            {
                imageListGownPage8 = new List<string>();
            }

            // Thêm các ảnh mới vào danh sách
            imageListGownPage8.AddRange(uploadedImages);

            // Cập nhật lại danh sách ảnh vào tệp JSON của Album 3
            var updatedJsonData = JsonSerializer.Serialize(imageListGownPage8);
            System.IO.File.WriteAllText(albumFilePath, updatedJsonData);

            // Chuyển hướng lại trang Index để hiển thị danh sách hình ảnh mới
            return RedirectToAction("Index");
        }







        // Phương thức tải dữ liệu của cả hai album vào ViewBag
       private void LoadAlbumImages()
        {
            // Slider 1 
            if(System.IO.File.Exists(imageInfoFilePathSlider1))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider1);
                ViewBag.ImageUrlSlider1 = JsonSerializer.Deserialize<string>(jsonData);
            }
            // Slider 2
            if(System.IO.File.Exists(imageInfoFilePathSlider2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider2);
                ViewBag.ImageUrlSlider2 = JsonSerializer.Deserialize<string>(jsonData);
            }
            // Slider 3 
            if(System.IO.File.Exists(imageInfoFilePathSlider3))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePathSlider3);
                ViewBag.ImageUrlSlider3 = JsonSerializer.Deserialize<string>(jsonData);
            }
            // Album 1
            if (System.IO.File.Exists(imageInfoFilePath))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath);
                ViewBag.ImageUrl = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 2
            if (System.IO.File.Exists(imageInfoFilePath1))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath1);
                ViewBag.ImageUrlAlbum2 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 3
            if (System.IO.File.Exists(imageInfoFilePath2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath2);
                ViewBag.ImageUrlAlbum3 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 4
            if (System.IO.File.Exists(imageInfoFilePath3))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath3);
                ViewBag.ImageUrlAlbum4 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 5
            if (System.IO.File.Exists(imageInfoFilePath4))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath4);
                ViewBag.ImageUrlAlbum5 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 6
            if (System.IO.File.Exists(imageInfoFilePath5))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath5);
                ViewBag.ImageUrlAlbum6 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 7
            if (System.IO.File.Exists(imageInfoFilePath6))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath6);
                ViewBag.ImageUrlAlbum7 = JsonSerializer.Deserialize<string>(jsonData);
            }

            // Album 8
            if (System.IO.File.Exists(imageInfoFilePath7))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath7);
                ViewBag.ImageUrlAlbum8 = JsonSerializer.Deserialize<string>(jsonData);
            }

            //Chỉnh sửa ảnh đại diện phần services

            if(System.IO.File.Exists(imageInfoFilePath8))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath8);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.ImageUrlAlbum9 = imageUrl;
            }

            if(System.IO.File.Exists(imageInfoFilePath9))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath9);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.ImageUrlAlbum10 = imageUrl;
            }

            if(System.IO.File.Exists(imageInfoFilePath10))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFilePath10);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.ImageUrlAlbum11 = imageUrl;
            }

            // image introduce 
            // image 1 
            if(System.IO.File.Exists(imageInfoFileIntroduce1))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce1);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlIntroduce1 = imageUrl;
            }

            // image 2 
            if(System.IO.File.Exists(imageInfoFileIntroduce2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce2);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlIntroduce2 = imageUrl;
            }

            // image 3 
            if(System.IO.File.Exists(imageInfoFileIntroduce3))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce3);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlIntroduce3 = imageUrl;
            }

            // image 4 
            if(System.IO.File.Exists(imageInfoFileIntroduce4))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileIntroduce4);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlIntroduce4 = imageUrl;
            }

            // image trang phục cưới 
            // trang phục cưới 1
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage1))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage1);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlWeddinggown1 = imageUrl;
            }
            // trang phục cưới 2
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage2);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlWeddinggown2 = imageUrl;
            }
            // trang phục cưới 3
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage3);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlWeddinggown3 = imageUrl;
            }
            // trang phục cưới 4
            if(System.IO.File.Exists(imageInfoFileWeddinggownpage4))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileWeddinggownpage4);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlWeddinggown4 = imageUrl;
            }

            // TRang Makeup 
            // Makeup 1

            if(System.IO.File.Exists(imageInfoFileMakeup1))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup1);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup1 = imageUrl;

            }

            // Makeup 2
            if(System.IO.File.Exists(imageInfoFileMakeup2))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup2);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup2 = imageUrl;

            }
            // Makeup 3
            if(System.IO.File.Exists(imageInfoFileMakeup3))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup3);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup3 = imageUrl;

            }
            // Makeup 4
            if(System.IO.File.Exists(imageInfoFileMakeup4))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup4);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup4 = imageUrl;

            }
            // Makeup 5
            if(System.IO.File.Exists(imageInfoFileMakeup5))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup5);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup5 = imageUrl;

            }
            // Makeup 6
            if(System.IO.File.Exists(imageInfoFileMakeup6))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup6);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup6 = imageUrl;

            }
            // Makeup 7
            if(System.IO.File.Exists(imageInfoFileMakeup7))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup7);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup7 = imageUrl;

            }
            // Makeup 8
            if(System.IO.File.Exists(imageInfoFileMakeup8))
            {
                var jsonData = System.IO.File.ReadAllText(imageInfoFileMakeup8);
                var imageUrl = JsonSerializer.Deserialize<string>(jsonData);
                ViewBag.imageUrlMakeup8 = imageUrl;

            }



        }



        

     



        





        

    }
}
