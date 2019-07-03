using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Core.Domain
{
    class Product
    {
        public int id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsPublished { get; set; }
    }
}
