using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSASS.Models
{
    public class Quotation
    {
        public int QID { get; set; }
        public int JobCardID { get; set; }
        public string customerNumber { get; set; }// ref from booking table
        public string FaultDescription { get; set; }
        public double Deposite { get; set; }
        public double Balance { get; set; }
        public double total { get; set; }
    }
}