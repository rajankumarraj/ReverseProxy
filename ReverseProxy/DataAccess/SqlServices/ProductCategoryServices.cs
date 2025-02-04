using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServices
{
    public class ProductCategoryServices : IProductCategoryServices
    {
        private readonly ISQLDataAccess _dataAccess;
        public ProductCategoryServices(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<IEnumerable<ProductCategoryModel>> GetProductcategories() => await _dataAccess.LoadData<ProductCategoryModel, dynamic>(StoreProceduer: "Sp_GetProductcategory", new { });

        public async Task<int> InsertProductCategory(ProductCategoryModel productCategoryModel) => await _dataAccess.Savedata(storeprocedure: "Sp_InsertProductCategory", new { productCategoryModel });
    }
}
