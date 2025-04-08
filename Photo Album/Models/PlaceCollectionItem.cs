using System.ComponentModel.DataAnnotations;

namespace Photo_Album.Models
{
    public class PlaceCollectionItem
    {
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? ImageUrl { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
