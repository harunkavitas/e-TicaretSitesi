﻿using System.Collections.Generic;

namespace Hunter.Models
{
    public class ShoppingCartVM
    {
        public  IEnumerable<ShoppingCart>ListCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
