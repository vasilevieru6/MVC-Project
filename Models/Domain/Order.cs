﻿using System;
using System.Collections.Generic;

namespace Models.Domain
{
    public enum OrderStatus { New, Hold, Shipped, Canceled };
    public class Order : Entity
    {
        public string Number { get; set; }
        public string Description { get; set; }
        public int TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
