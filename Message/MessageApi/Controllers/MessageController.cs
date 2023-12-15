using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageApi.Data;
using MessageApi.Models;

namespace MessageApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly StoreMS _db;

        public MessageController(StoreMS db)
        {
            _db = db;
        }

    [HttpGet]
    public IEnumerable<Message> GetMessage()
    {
        List<Message> message = _db.Messages.ToList();
        return message;
    }

    [HttpPost]
    public async Task<IActionResult> PostMessage(Message message)
    {
        Console.WriteLine("MEssage recieved");
        if(message == null)
        {
            return BadRequest();
        }
        await _db.AddAsync(message);
        await _db.SaveChangesAsync();
        return Ok();
    }
    }
}