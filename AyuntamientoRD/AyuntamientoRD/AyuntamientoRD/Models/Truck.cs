using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.Models
{
    public class Truck
    {
        public int IdTruck { get; set; }
        public List<Route> Routes { get; set; }
        public bool IsDriving { get; set; }
        public List<DateTime> DateBeginWork { get; set; }
    }
}
