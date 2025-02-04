using DataAccess;
using DataAccess.Models;
using DataAccess.SqlServices;
using InvoiceService.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace InvoiceService.Controllers
{
    [Route("api/invoice")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly  IInvoiceServices _invoiceServices;
        public InvoiceController(IInvoiceServices invoiceServices)
        {
            _invoiceServices = invoiceServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoice(int PageSize, int PageNum)
        {
           return Ok(await _invoiceServices.GetInvoicePager(PageSize, PageNum));
        }

        [HttpPost]
        public async Task<IActionResult> PostInvoice(AddInvoiceVM addInvoiceVM)
        {
            if (addInvoiceVM != null)
            {
                InvoiceModel invoiceModel = new InvoiceModel
                {
                    CustomerId = addInvoiceVM.CustomerId,
                    TotalAmount = addInvoiceVM.TotalAmount,
                    Tax = addInvoiceVM.Tax,
                    Discount = addInvoiceVM.Discount,
                    Amount = addInvoiceVM.Amount,
                    InvoiceStatus = addInvoiceVM.InvoiceStatus,
                    PaymentMode = addInvoiceVM.PaymentMode
                };
                return Ok(await _invoiceServices.AddInvoice(invoiceModel));


            }
            else
            {
                return Ok(new { v = 0 });
            }
        }
    }
}
