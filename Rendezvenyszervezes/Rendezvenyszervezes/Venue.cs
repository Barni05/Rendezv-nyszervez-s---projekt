namespace Rendezvenyszervezes {
    class Venue {
        int capacity;
        TimeOfDay availability;
        int elegance;
        VenueType venueType;

        public int Capacity {
            get {
                return capacity;
            }
        }

        public TimeOfDay Availability {
            get {
                return availability;
            }
        }

        public int Elegance {
            get {
                return elegance;
            }
        }

        public VenueType Type {
            get {
                return venueType;
            }
        }

        public Venue(int capacity, TimeOfDay availability, int elegance, VenueType venueType) {
            this.capacity = capacity;
            this.availability = availability;
            this.elegance = elegance;
            this.venueType = venueType;
        }
    }
}