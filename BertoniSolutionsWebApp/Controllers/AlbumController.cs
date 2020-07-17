using System.Threading.Tasks;
using BertoniSolutionsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutionsWebApp.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IJsonPlaceholderService service;

        public AlbumController(IJsonPlaceholderService service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            var albums = await this.service.GetAlbumsAsync();
            
            return View(albums);
        }
    }
}