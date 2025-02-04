using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public  class InvoiceModel
    {
        public int Id { get; set; } 
        public int CustomerId { get; set; }
        public long TotalAmount { get; set; }   
        public long Tax { get; set; }   
        public long Discount { get; set; }  
        public long  Amount {get;set; }
        public string? InvoiceStatus { get; set; }
        public string? PaymentMode { get; set; }
        public DateTime CreatedOn { get; set; } 

    }
}
