using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServices
{
    public class InvoiceServices : IInvoiceServices
    {
        private readonly ISQLDataAccess DBAccess;
        public InvoiceServices(ISQLDataAccess sQLDataAccess)
        {
            DBAccess = sQLDataAccess;
        }
        public async Task<IEnumerable<InvoiceModel>> GetInvoicePager(int Pagesize, int PageNum) => await DBAccess.LoadData<InvoiceModel, dynamic>(StoreProceduer: "Sp_GetInvoicePager", new { Pagesize, PageNum });
        public async Task<int> AddInvoice(InvoiceModel invoice) => await DBAccess.Savedata(storeprocedure: "Sp_InsertInvoice", new { invoice.CustomerId, invoice.TotalAmount,invoice.Tax,invoice.Discount, invoice.Amount, invoice.InvoiceStatus, invoice.PaymentMode });
    }
}
