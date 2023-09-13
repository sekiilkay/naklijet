using AutoMapper;
using JwtUser.Core.DTOs.Request;
using JwtUser.Core.Entities;
using JwtUser.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtUser.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;
        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(AddMessageDto messageDto)
        {
            var message = _mapper.Map<Message>(messageDto);

            await _messageService.AddAsync(message);
            return Ok("Data add succeeded");
        }

        [HttpGet]
        public async Task<IActionResult> GetMessages(string userid, string comid)
        {
            var values = await _messageService.GetMessages(userid,comid);
            return Ok(values);
        }
    }
}
