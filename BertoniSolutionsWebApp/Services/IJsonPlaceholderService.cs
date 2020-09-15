using System.Collections.Generic;
using System.Threading.Tasks;
using BertoniSolutionsWebApp.Models;

namespace BertoniSolutionsWebApp.Services
{
    public interface IJsonPlaceholderService
    {
        Task<IEnumerable<Album>> GetAlbumsAsync();

        Task<IEnumerable<Photo>> GetAlbumPhotosAsync(int albumId);

        Task<IEnumerable<Comment>> GetPhotoCommentsAsync(int photoId);
    }
}