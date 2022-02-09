using System.Linq;
using AM.Events.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AM.Events.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : ControllerBase
    {

        public IEnumerable<Event> _events =  new Event[]
        {             
                new Event() {
                    EventId = 1,
                    Place = "Recife",
                    EventDate = "13/05/2022",
                    Theme = "Festival de Verão",
                    TotalPeople = 9999,
                    SalesLevel = "1",
                    ImageURL = "http:www.google.com"
                },
                new Event() {
                    EventId = 2,
                    Place = "Recife",
                    EventDate = "13/05/2022",
                    Theme = "Festival de Verão",
                    TotalPeople = 9999,
                    SalesLevel = "1",
                    ImageURL = "http:www.google.com"
                },
                 new Event() {
                    EventId = 3,
                    Place = "Recife",
                    EventDate = "13/05/2022",
                    Theme = "Festival de Verão",
                    TotalPeople = 9999,
                    SalesLevel = "1",
                    ImageURL = "http:www.google.com"
                },

        };


        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

         [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _events.Where(e => e.EventId == id);
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