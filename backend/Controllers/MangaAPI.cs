using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.IO;

using backend.ViewModels;
using backend.webscrape;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MangaAPI : Controller
    {
        private readonly ILogger<MangaAPI> _logger;

        public MangaAPI(ILogger<MangaAPI> logger)
        {
            _logger = logger;
        }


        [HttpGet("Search")]
        public IActionResult Search(string mangaName)
        {

            var model = new testJsonString{
                jmeno = mangaName,
                prijmeni = "parek",
                vek = "19",
                veci = new Dictionary<string, string>
                {
                    {"nazev", "lolololol"},
                    {"pipik", "ano"}
                }
            };

            return new JsonResult(model);
        }


        [HttpGet("Download")]
        public async Task<IActionResult> Download()
        {
            var path = "/home/vojta/Desktop/MangaKatWeb/backend/downFiles/mang.zip";

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            var ext = Path.GetExtension(path).ToLowerInvariant();

            return File(memory, "application/zip", "lol.zip");
        }


        [HttpGet("mangainfo")]
        public IAsyncResult getMangaInfo()
        {
            string mangaName = getMangaInfo.mangaTitle();

            var model = new testJsonString{
                jmeno = mangaName,
                prijmeni = "parek",
                vek = "19",
                veci = new Dictionary<string, string>
                {
                    {"nazev", "lolololol"},
                    {"pipik", "ano"}
                }
            };

            return new JsonResult(model);
        }

    }
}