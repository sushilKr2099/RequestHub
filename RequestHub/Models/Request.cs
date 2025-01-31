using System.ComponentModel.DataAnnotations;

namespace RequestHub.Models
{
    public class Request
    {
        [Required]
        public string Product { get; set; } = string.Empty;

        [Required]
        public string SubProduct { get; set; } = string.Empty;

        [Required]
        public string RequestType { get; set; } = string.Empty;

        [Required]
        public string SubRequestType { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid Mobile Number")]
        public string Mobile { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Description should be alphanumeric")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"\.(png|jpg|jpeg|pdf)$", ErrorMessage = "Invalid file format")]
        public string Attachment { get; set; } = string.Empty;
    }
}
