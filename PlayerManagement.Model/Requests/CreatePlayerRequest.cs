using PlayerManagement.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PlayerManagement.Model.Requests
{
    public class CreatePlayerRequest
    {
        [Required(ErrorMessage = "{0} is required")]
        public required string FullName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public required DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Range(30, 250, ErrorMessage = "Please enter a value bigger than {0}")]
        public required int Height { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public required Position Position { get; set; }

        public int? TeamId { get; set; }
    }
}
