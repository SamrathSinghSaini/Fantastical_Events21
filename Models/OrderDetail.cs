using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }

        public double Price { get; set; }
        public String CustomerId { get; set; }

        public Order Order { get; set; }

        public int OrderId { get; set; }

        public Activity Activity { get; set; }

        public int ActivityID { get; set; }
    }
}
