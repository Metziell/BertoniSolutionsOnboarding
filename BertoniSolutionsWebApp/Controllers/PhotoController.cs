using System.Threading.Tasks;
using BertoniSolutionsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutionsWebApp.Controllers
{
    public class PhotoController : Controller
    {
        private readonly IJsonPlaceholderService service;

        public PhotoController(IJsonPlaceholderService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Index(int albumId)
        {
            var photos = await this.service.GetAlbumPhotosAsync(albumId);

            return this.View(photos);
        }
    }
}