using System;
using System.Collections.Generic;

namespace ORM_Second_Assessment_.Models
{
    public partial class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string ShortCode { get; set; }
        public DateTime? Date { get; set; }
    }
}
