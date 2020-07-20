using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.Models
{
   public class Complaints
    {
        public int  Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateComplaint { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
