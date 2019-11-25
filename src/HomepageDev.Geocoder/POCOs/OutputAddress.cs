﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomepageDev.Geocoder.POCOs
{
    public class OutputAddress
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Confidence { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Source { get; set; }
    }
}