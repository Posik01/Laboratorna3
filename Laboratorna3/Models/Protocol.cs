using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorna3.Models
{
    public class Protocol
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string OffenderData { get; set; }
        public string Situation { get; set; }
        public string OfficerData { get; set; }
        public string Witnesses { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}