using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class UserModel
    {
        [Required]
        [StringLength(16, ErrorMessage = "Name is too long.")]
        public string? DisplayName { get; set; }
        
        [Required]
        [StringLength (6, MinimumLength = 6, ErrorMessage = "Access code must be 6 digits long.")]
        public string? AccessCode { get; set; }
    }
}
