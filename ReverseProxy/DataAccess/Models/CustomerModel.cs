using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public  class CustomerModel
    {
        public int Id { get; set; }
        public string? CustomerName {  get; set; }   
        public string Address1 { get; set; }    =string.Empty;
        public string Address2 { get; set; }  = string.Empty;
        public string Pin { get; set; } = string.Empty;
        public string City { get; set; }=string.Empty;  
        public string State { get; set; } =string.Empty;    
        public string Country { get;set; } =string.Empty;   

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedOn { get; set; }
    }
}
