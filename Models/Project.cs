using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string[] Technologies { get; set; }
        public string CoverImageUrl { get; set; }
        public string[] ImagesUrl { get; set; }
        public string Link { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
    }
}
