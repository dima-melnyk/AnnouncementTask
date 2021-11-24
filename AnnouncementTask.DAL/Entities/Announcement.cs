using System;

namespace AnnouncementTask.DAL.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
