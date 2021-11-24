using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnnouncementTask.DAL.Entities
{
    public class Announcement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
