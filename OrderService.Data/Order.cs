using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Data
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<Item> Items { get; set; }
        public Customer Customer { get; set; }
        public Address Address { get; set; }
    }
}
