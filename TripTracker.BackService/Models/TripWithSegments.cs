using System.Collections.Generic;

namespace TripTracker.BackService.Models
{
    public class TripWithSegments : TripTrackerDTO.Trip
    {
        public ICollection<Segment> Segments { get; set; }
    }
}
