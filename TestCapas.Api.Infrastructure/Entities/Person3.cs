using System;
using System.Collections.Generic;

#nullable disable

namespace TestCapas.Api.Infrastructure.Entities
{
    public partial class Person3
    {
        public int BusinessEntityId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? EmailPromotion { get; set; }
    }
}
