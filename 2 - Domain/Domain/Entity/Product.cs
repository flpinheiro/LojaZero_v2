using System;
using System.Collections.Generic;
using System.Text;

namespace LojaZero.Domain.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
