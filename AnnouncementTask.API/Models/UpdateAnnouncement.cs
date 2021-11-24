using System.ComponentModel.DataAnnotations;

namespace AnnouncementTask.API.Models
{
    public class UpdateAnnouncement
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
