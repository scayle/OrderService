using System;
using System.Collections.Generic;
using System.Text;

namespace OrderService.Data
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
