using System.Collections.Generic;
using System.Threading.Tasks;
using BertoniSolutionsWebApp.Models;

namespace BertoniSolutionsWebApp.Services
{
    public interface IJsonPlaceholderService
    {
        Task<IList<Album>> GetAlbumsAsync();

        Task<IList<Photo>> GetAlbumPhotosAsync(int albumId);

        Task<IList<Comment>> GetPhotoCommentsAsync(int photoId);
    }
}