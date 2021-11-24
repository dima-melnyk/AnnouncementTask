using System.ComponentModel.DataAnnotations;

namespace AnnouncementTask.API.Models
{
    public class CreateAnnouncement
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
