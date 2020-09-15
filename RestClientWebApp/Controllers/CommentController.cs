using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestClientWebApp.Services;

namespace RestClientWebApp.Controllers
{
    public class CommentController : Controller
    {
        private readonly IJsonPlaceholderService service;

        public CommentController(IJsonPlaceholderService service)
        {
            this.service = service;
        }
        
        public async Task<IActionResult> Index(int photoId)
        {
            var comments = await this.service.GetPhotoCommentsAsync(photoId);

            return this.View(comments);
        }
    }
}