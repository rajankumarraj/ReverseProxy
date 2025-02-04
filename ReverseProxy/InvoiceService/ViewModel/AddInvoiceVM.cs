namespace InvoiceService.ViewModel
{
    public class AddInvoiceVM
    {
        public int CustomerId { get; set; }
        public long TotalAmount { get; set; }
        public long Tax { get; set; }
        public long Discount { get; set; }
        public long Amount { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? PaymentMode { get; set; }
    }
}
