using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestClientWebApp.Services;

namespace RestClientWebApp.Controllers
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
            
            return this.View(albums);
        }
    }
}