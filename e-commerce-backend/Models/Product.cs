using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_backend.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
