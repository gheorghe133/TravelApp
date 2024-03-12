using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelApplication.Models
{
    public class Product
    {
        public string Title { get; set; }
        
        public string Description { get; set; }

        public string Photo { get; set; }

        public double Price { get; set; }
    }
}