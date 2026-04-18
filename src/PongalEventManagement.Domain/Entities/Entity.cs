using System;
using System.Collections.Generic;
using System.Text;

namespace PongalEventManagement.Domain.Entities
{
    public class Event
    {
        public int Id {  get; set; }
        public string Name { get; set; } = "";
        public DateTime Date { get; set; }
        public string Location { get; set; } = "";
    }
}
