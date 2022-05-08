using System;
using System.Collections.Generic;

#nullable disable

namespace TestCapas.Api.Infrastructure.Entities
{
    public partial class Sale
    {
        public int SalesId { get; set; }
        public double? ProductId { get; set; }
        public double? Price { get; set; }
        public int? CustomerId { get; set; }
        public int? Quantity { get; set; }
        public double? Subtotal { get; set; }
    }
}
