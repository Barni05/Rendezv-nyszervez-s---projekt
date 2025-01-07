using System;
using System.Collections.Generic;
namespace Rendezvenyszervezes {
    class Event {
        Venue venue;
        DateTime start;
        DateTime end;
        EventType type;
        List<Equipment> equipment;
    }
}