using System.ComponentModel;

namespace RestClientWebApp.Models
{
    public class Album
    {
        [DisplayName("User ID")]
        public int UserId { get; set; }

        [DisplayName("Album ID")]
        public int Id { get; set; }

        [DisplayName("Title")]
        public string Title { get; set; }
    }
}
