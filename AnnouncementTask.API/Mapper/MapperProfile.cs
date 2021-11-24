using AnnouncementTask.BLL.Models;
using AnnouncementTask.DAL.Entities;
using AutoMapper;

namespace AnnouncementTask.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Announcement, AnnouncementModel>()
                .ForMember(am => am.CreationDate, opt => opt.MapFrom(a => a.CreationDate.ToString("dd.MM.yyyy")));
        }
    }
}
