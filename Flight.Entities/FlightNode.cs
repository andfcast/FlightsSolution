﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Entities
{
    public class FlightNode
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public double Price { get; set; }

        public bool Checked { get; set; }
    }
}
