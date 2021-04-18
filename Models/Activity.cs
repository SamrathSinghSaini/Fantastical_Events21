using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Fantastical_Events_2021.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        [Required]
        public String ActivityName { get; set; }
        public String Description { get; set; }

        public double Price { get; set; }

        public String Photo { get; set; }


        public Event Event { get; set; }

        public int EventId { get; set; }

        public String EventName { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public List<Cart> Carts { get; set; }
    }
}
