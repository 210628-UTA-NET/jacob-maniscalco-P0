using System;
using System.Collections.Generic;

#nullable disable

namespace StoreDL.Entities
{
    public partial class LineItem
    {
        public int LineId { get; set; }
        public int? Quantity { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
