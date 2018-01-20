﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MT.GridView.Models
{
    public class Customer
    {
        public int Id { get; set; }        
        public string CompanyName { get; set; }        
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }               
        public string Country { get; set; }
        public string Phone { get; set; }        
        public DateTime Founded { get; set; }
    }   
}