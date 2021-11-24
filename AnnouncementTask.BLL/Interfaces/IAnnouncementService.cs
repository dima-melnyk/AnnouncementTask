using AnnouncementTask.BLL.Models;
using AnnouncementTask.DAL.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnnouncementTask.BLL.Interfaces
{
    public interface IAnnouncementService
    {
        Task<IEnumerable<AnnouncementModel>> GetAll();
        Task<AnnouncementModel> Get(int id);
        Task Create(Announcement newAnnouncement);
        Task Update(Announcement updateAnnouncement);
        Task Delete(int id);
    }
}
