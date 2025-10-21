using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yummy.Api.Context;
using Yummy.Api.DTO.MessageDTO;
using Yummy.Api.Entity;

namespace Yummy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiContext _context;

        public MessageController(IMapper mapper, ApiContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var values = _context.Messages.ToList();
            return Ok(_mapper.Map<List<ResultMessageDTO>>(values));
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDTO createMessageDTO)
        {
            var values = _mapper.Map<Message>(createMessageDTO);
            _context.Messages.Add(values);
            _context.SaveChanges();
            return Ok("Mesaj Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteMessage(int id)
        {
            var values = _context.Messages.Find(id);
            _context.Messages.Remove(values);
            _context.SaveChanges();
            return Ok("Silme Başarılı");
        }

        [HttpGet("GetMessage")]
        public IActionResult GetMessage(int id)
        {
            var value = _context.Messages.Find(id);
            return Ok(_mapper.Map<GetByIDMessageDTO>(value));
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDTO updateMessageDTO)
        {
            var values = _mapper.Map<Message>(updateMessageDTO);
            _context.Messages.Update(values);
            _context.SaveChanges();
            return Ok("Güncelleme Başarılı");
        }
    }


}
