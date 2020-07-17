using System.Threading.Tasks;
using BertoniSolutionsWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace BertoniSolutionsWebApp.Controllers
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