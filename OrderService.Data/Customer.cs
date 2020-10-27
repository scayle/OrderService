using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.Data
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DefaultAddress { get; set; }
        public List<Address> Address { get; set; }
    }
}
