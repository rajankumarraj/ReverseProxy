using DataAccess.Models;

namespace DataAccess.SqlServices
{
    public interface IInvoiceServices
    {
        Task<int>  AddInvoice(InvoiceModel invoice);
        Task<IEnumerable<InvoiceModel>> GetInvoicePager(int Pagesize, int PageNum);
    }
}