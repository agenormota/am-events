namespace AM.Events.API.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Place { get; set; }
        public string EventDate { get; set; }
        public string Theme { get; set; }
        public int TotalPeople { get; set; }
        public string SalesLevel { get; set; }
        public string ImageURL { get; set; }

    }
}
