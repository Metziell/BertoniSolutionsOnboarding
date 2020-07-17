using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BertoniSolutionsWebApp.Models;
using RestSharp;

namespace BertoniSolutionsWebApp.Services
{
    public class JsonPlaceholderService : IJsonPlaceholderService
    {
        private const string JsonPlaceholderUrl = "http://jsonplaceholder.typicode.com";

        public async Task<IList<Album>> GetAlbumsAsync()
        {
            var client = new RestClient(JsonPlaceholderUrl);

            var request = new RestRequest("albums", DataFormat.Json);

            return await client.GetAsync<IList<Album>>(request);
        }

        public async Task<IList<Photo>> GetAlbumPhotosAsync(int albumId)
        {
            var client = new RestClient(JsonPlaceholderUrl);

            var request = new RestRequest($"albums/{albumId}/photos", DataFormat.Json);

            return await client.GetAsync<IList<Photo>>(request);
        }

        public async Task<IList<Comment>> GetPhotoCommentsAsync(int photoId)
        {
            var client = new RestClient(JsonPlaceholderUrl);

            var request = new RestRequest($"photos/{photoId}/comments", DataFormat.Json);

            var allComments = await client.GetAsync<IEnumerable<Comment>>(request);
            return allComments.Where(com => com.PostId == photoId).ToList();
        }
    }
}
