﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public  class ProductCategoryModel
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }    
        public bool IsActive { get; set; }  
    }
}
