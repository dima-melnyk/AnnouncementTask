using AnnouncementTask.BLL.Interfaces;
using AnnouncementTask.BLL.Models;
using AnnouncementTask.DAL;
using AnnouncementTask.DAL.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnnouncementTask.BLL.Services
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationContext _context;

        public AnnouncementService(IMapper mapper, ApplicationContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IEnumerable<AnnouncementModel>> GetAll() => 
            (await _context.Announcements.ToListAsync()).Select(_mapper.Map<AnnouncementModel>);

        public async Task<AnnouncementModel> Get(int id) =>
            _mapper.Map<AnnouncementModel>(await GetById(id));

        public async Task Create(Announcement newAnnouncement)
        {
            await _context.AddAsync(newAnnouncement);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Announcement updateAnnouncement)
        {
            _context.Update(updateAnnouncement);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            _context.Remove(await GetById(id));
            await _context.SaveChangesAsync();
        }

        private async Task<Announcement> GetById(int id)
        {
            var model = await _context.Announcements.FindAsync(id);

            return model ?? throw new KeyNotFoundException("Entity does not found");
        }
    }
}
