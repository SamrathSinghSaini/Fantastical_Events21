using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public String CustomerID { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String Address { get; set; }
        public String City { get; set; }
        public String Province { get; set; }

        public int Phone { get; set; }

        public Double OrderTotal { get; set; }





        public List<OrderDetail> OrderDetails { get; set; }
    }
}
