﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TinyCRM
{
    class Order
    {
        public string OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
