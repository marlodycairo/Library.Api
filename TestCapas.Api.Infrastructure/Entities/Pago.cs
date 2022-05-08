using System;
using System.Collections.Generic;

#nullable disable

namespace TestCapas.Api.Infrastructure.Entities
{
    public partial class Pago
    {
        public int PagosId { get; set; }
        public int? CustomerId { get; set; }
        public double? TotalDeuda { get; set; }
        public double? Abono { get; set; }
        public double? Saldo { get; set; }
    }
}
