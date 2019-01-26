using System.ComponentModel.DataAnnotations;

namespace Sample.DataModel
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your name is required")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, ErrorMessage = "Your email is required")]
        [RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your message is required")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
