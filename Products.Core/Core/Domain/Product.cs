using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MinLength(1)]
        public string Name { get; set; }
        [Required, MinLength(1)]
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsPublished { get; set; }
    }
}
