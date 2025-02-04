using DataAccess.Models;

namespace DataAccess.SqlServices
{
    public interface IProductCategoryServices
    {
        Task<IEnumerable<ProductCategoryModel>> GetProductcategories();
        Task<int> InsertProductCategory(ProductCategoryModel productCategoryModel);
    }
}