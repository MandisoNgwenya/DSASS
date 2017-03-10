using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSASS.Models
{
    public class Booking
    {
         public int ID  { get; set; }
        public string CustomerNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string IDNumber { get; set; }
        public string Address { get; set; }
        public string TelNo { get; set; }
        public DateTime date { get; set; }
        public string device { get; set; }
        public string Model { get; set; }
        public string serialNo { get; set; }
        public string Signature { get; set; }
        public int p { get; set; }

    }
}