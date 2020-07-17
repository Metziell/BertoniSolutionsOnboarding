using System;
using System.ComponentModel;

namespace BertoniSolutionsWebApp.Models
{
    public class Photo
    {
        public int AlbumId { get; set; }

        [DisplayName("Photo ID")]
        public int Id { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }
        
        [DisplayName("Image URL")]
        public Uri Url { get; set; }

        [DisplayName("Image Thumbnail URL")]
        public Uri ThumbnailUrl { get; set; }
    }
}
