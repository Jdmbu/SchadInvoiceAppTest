using System;
using System.Collections.Generic;

#nullable disable

namespace SchadInvoiceApp.Models
{
    public partial class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
