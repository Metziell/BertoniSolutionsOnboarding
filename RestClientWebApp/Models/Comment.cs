using System.ComponentModel;

namespace RestClientWebApp.Models
{
    public class Comment
    {
        [DisplayName("Photo ID")]
        public int PostId { get; set; }

        [DisplayName("Comment ID")]
        public int Id { get; set; }

        [DisplayName("User Name")]
        public string Name { get; set; }

        [DisplayName("User e-mail")]
        public string Email { get; set; }

        [DisplayName("Body")]
        public string Body { get; set; }
    }
}
