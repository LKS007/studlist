﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JQGridApp.Models
{
    public class Catalog
    {
        public int Id { get;set;}
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public string Indekses { get; set; }
        public DateTime Date { get; set; }
    }
}