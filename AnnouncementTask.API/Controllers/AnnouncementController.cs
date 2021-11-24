using AnnouncementTask.API.Models;
using AnnouncementTask.BLL.Interfaces;
using AnnouncementTask.BLL.Models;
using AnnouncementTask.DAL.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnnouncementTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _service;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _service.Get(id));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateAnnouncement announcement)
        {
            var model = _mapper.Map<Announcement>(announcement);
            await _service.Create(model);

            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateAnnouncement announcement)
        {
            var model = _mapper.Map<Announcement>(announcement);
            model.Id = id;
            await _service.Update(model);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok();
        }
    }
}
