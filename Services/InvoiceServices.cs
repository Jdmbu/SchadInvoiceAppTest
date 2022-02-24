using SchadInvoiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchadInvoiceApp.Services
{
    public class InvoiceServices : IInvoiceServices
    {
        Models.Invoice _invoice;
        Models.InvoiceDetail _invoiceDetail;
        public Invoice mtGetInvoice()
        {
            return _invoice;
        }

        public void mtSetInvoice(Invoice header, InvoiceDetail detail)
        {
            _invoice = header;
            _invoiceDetail = detail;
            _invoiceDetail.SubTotal = detail.Qty * detail.Price;
            _invoiceDetail.TotalItbis = _invoiceDetail.SubTotal * (decimal)0.18;
            _invoiceDetail.Total = _invoiceDetail.SubTotal + _invoiceDetail.TotalItbis;

            _invoice.CustomerId = detail.CustomerId;
            _invoice.SubTotal = _invoiceDetail.SubTotal;
            _invoice.TotalItbis = _invoiceDetail.TotalItbis;
            _invoice.Total = _invoiceDetail.Total;
        }
    }
}
