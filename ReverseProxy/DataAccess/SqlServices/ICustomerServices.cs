using DataAccess.Models;

namespace DataAccess.SqlServices
{
    public interface ICustomerServices
    {
        Task<IEnumerable<CustomerModel>> GetAllCustomerPager(int PageSize, int Pagenum);
        Task <int> InsertCustomer(CustomerModel customerModel);
    }
}