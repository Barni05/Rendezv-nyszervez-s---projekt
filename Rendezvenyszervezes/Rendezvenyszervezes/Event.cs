using System;
using System.Collections.Generic;
namespace Rendezvenyszervezes {
    class Event {
        Venue venue;
        DateTime start;
        DateTime end;
        EventType type;
        List<Equipment> equipment;

        public Event(Venue venue, DateTime start, DateTime end, EventType type, List<Equipment> equipment) {
            this.venue = venue;
            this.start = start;
            this.end = end;
            this.type = type;
            this.equipment = equipment;
        }
    }
}