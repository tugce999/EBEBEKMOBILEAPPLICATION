﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ebebdeneme.Models
{
    public class Cart
    {
        public string UserName { get; set; }
        public int CartId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}
