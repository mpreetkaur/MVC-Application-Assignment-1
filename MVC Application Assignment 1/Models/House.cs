﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Application_Assignment_1.Models
{
    public class House
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int LotSize { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}