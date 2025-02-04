using DataAccess.Models;

namespace DataAccess.SqlServices
{
    public interface IProductServices
    {
        Task<IEnumerable<ProductModel>> GetAllProductpages(int PageSize, int PageNum);
        Task<int> InsertProduct(ProductModel productModel);
    }
}