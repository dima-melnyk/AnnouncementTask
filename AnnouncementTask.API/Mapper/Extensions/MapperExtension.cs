using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace AnnouncementTask.API.Mapper.Extensions
{
    public static class MapperExtension
    {
        public static void AddMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc => mc.AddProfile(new MapperProfile()));

            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
