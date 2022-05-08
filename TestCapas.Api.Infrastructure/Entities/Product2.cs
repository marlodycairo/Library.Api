using System;
using System.Collections.Generic;

#nullable disable

namespace TestCapas.Api.Infrastructure.Entities
{
    public partial class Product2
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public double? ListPrice { get; set; }
        public string Size { get; set; }
    }
}
