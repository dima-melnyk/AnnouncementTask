using AnnouncementTask.API.Models;
using AnnouncementTask.BLL.Models;
using AnnouncementTask.DAL.Entities;
using AutoMapper;
using System;

namespace AnnouncementTask.API.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Announcement, AnnouncementModel>()
                .ForMember(am => am.CreationDate, opt => opt.MapFrom(a => a.CreationDate.ToString("dd.MM.yyyy")));

            CreateMap<CreateAnnouncement, Announcement>()
                .ForMember(a => a.CreationDate, opt => opt.MapFrom(am => DateTime.Now));
            CreateMap<UpdateAnnouncement, Announcement>();
        }
    }
}
