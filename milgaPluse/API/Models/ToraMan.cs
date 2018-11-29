using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class ToraMan
    {
        [Required]
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int telephon { get; set; }
        public int cellularTelephone1 { get; set; }
        public int cellularTelephone2 { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int buildingNumber { get; set; }
        public int homeNumber { get; set; }
        public int zipCode { get; set; }
        public DateTime birthDate { get; set; }
        public bool children { get; set; }
        public bool fullDay { get; set; }
        public bool doingTest { get; set; }
        public int refundTransportation { get; set; }
    }
}