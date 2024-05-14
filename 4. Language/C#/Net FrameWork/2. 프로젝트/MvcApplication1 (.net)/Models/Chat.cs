using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class Chat
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string ChatId { get; set; }

        [Required]
        public string UserIdContext { get; set; }

        [Required]
        public string ChatIdContext { get; set; }
    }
}
