using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public  class ProductModel
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public int Category { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedOn { get; set; }

    }
}
