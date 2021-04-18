using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Models
{
    public class Cart
    {
        public int CartId { get; set; } //PK

        public int ActivityId { get; set; }

        public DateTime DateCreated { get; set; }

        public string CustomerId { get; set; }

        public int Quantity { get; set; }

        public Activity Activity { get; set; }
    }
}
