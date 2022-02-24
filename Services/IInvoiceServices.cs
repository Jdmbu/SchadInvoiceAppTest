using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchadInvoiceApp.Services
{
    public interface IInvoiceServices
    {
        void mtSetInvoice(Models.Invoice header, Models.InvoiceDetail detail);
        Models.Invoice mtGetInvoice();
    }
}
