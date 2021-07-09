using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public string OrderLocation { get; set; }
        public decimal? OrderPrice { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
