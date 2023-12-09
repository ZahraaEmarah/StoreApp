﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{   
    #nullable disable annotations
    public enum Status
    {
        Pending, Approved, Declined, Shipped, Delivered
    }
    public class Order
    {
        public string Id { get; set; }
        public DateOnly CreatedDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string CustomerId { get; set; }
        public Status Status { get; set; }
        public Customer Customer { get; set; }

    }
}
