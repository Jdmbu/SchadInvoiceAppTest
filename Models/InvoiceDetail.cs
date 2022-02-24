using System;
using System.Collections.Generic;

#nullable disable

namespace SchadInvoiceApp.Models
{
    public partial class InvoiceDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public decimal TotalItbis { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
