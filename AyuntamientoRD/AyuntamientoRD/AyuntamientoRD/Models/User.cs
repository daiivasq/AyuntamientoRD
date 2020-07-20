using System;
using System.Collections.Generic;
using System.Text;

namespace AyuntamientoRD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string TypeUser { get; set; }
        public long Phone { get; set; }
        public long Cedula { get; set; }
    }
}
