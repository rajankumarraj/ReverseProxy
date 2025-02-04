using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServices
{
    public class ProductServices : IProductServices
    {
        private readonly ISQLDataAccess _dataAccess;
        public ProductServices(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task<IEnumerable<ProductModel>> GetAllProductpages(int PageSize, int PageNum) => await _dataAccess.LoadData<ProductModel, dynamic>(StoreProceduer: "Sp_GetProductPager", new { PageSize, PageNum });

        public async Task<int>  InsertProduct(ProductModel productModel) => await _dataAccess.Savedata(storeprocedure: "Sp_InsertProduct", new { productModel.ProductName, productModel.Category });
    }
}
