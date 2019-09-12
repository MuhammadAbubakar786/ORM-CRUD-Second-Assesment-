﻿using System;
using System.Collections.Generic;

namespace ORM_Second_Assessment_.Models
{
    public partial class Flight
    {
        public int Id { get; set; }
        public int? AirlineId { get; set; }
        public string Source { get; set; }
        public string Destinantion { get; set; }
        public DateTime? DepartialDateTime { get; set; }
        public DateTime? ArrivalDateTime { get; set; }
    }
}
