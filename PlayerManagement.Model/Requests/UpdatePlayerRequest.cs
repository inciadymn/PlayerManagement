using PlayerManagement.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PlayerManagement.Model.Requests
{
    public class UpdatePlayerRequest
    {
        [Required(ErrorMessage = "{0} is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(30, 250, ErrorMessage = "Please enter a value bigger than {0}")]
        public int Height { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public Position Position { get; set; }

        public int? TeamId { get; set; }
    }
}
