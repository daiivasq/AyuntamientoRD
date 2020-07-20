using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.Models
{
    public class Route
    {
      
        public GeoCoordinate Origin  { get; set; }
        public GeoCoordinate Destination { get; set; }

        public string TravelMode { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TimeDistance { get; set; }
    }
    public class GeoCoordinate {
        public string Address { get; set; }
        public double Lat { get; set; }
        public double Log { get; set; }

    }

}
