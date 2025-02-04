using System.ComponentModel.DataAnnotations;

namespace NZWalks.API.Models.DTOs
{
    public class AddRegionRequestDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Code has to be a minimum of 3 characters.")]      // Min and max of the same number indicates that only 3 characters are allowed
        [MaxLength(3, ErrorMessage = "Code has to be a maximum of 3 characters.")]

        public string Code { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Name has to be a maximum of 100 characters.")]
        public string Name { get; set; }

        // Not required since it is an optional parameter
        public string? RegionImageUrl { get; set; }
    }
}
