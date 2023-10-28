using System.ComponentModel.DataAnnotations;

namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Required]
        public int Id { set; get; }
        [Required]
        public string? Name { set; get; }
        [Required]
        public string? Publisher { set; get; }
        [Required]
        public string? Cost { set; get; }
    }
}