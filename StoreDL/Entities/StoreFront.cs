﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class StoreFront
    {
        public StoreFront()
        {
            Orders = new HashSet<Order>();
        }

        public int StoreFrontId { get; set; }
        public string StoreFrontName { get; set; }
        public string StoreFrontAddress { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
