using System.Linq;
using AM.Events.API.Data;
using AM.Events.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AM.Events.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        public readonly DataContext _context;
        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

         [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _context.Events.Where(e => e.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Retorno Post";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Retorno Put id:{id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Retorno Delete id:{id}";
        }

    }
}