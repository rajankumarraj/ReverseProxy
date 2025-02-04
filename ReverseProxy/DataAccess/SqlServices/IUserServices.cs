using DataAccess.Models;

namespace DataAccess.SqlServices
{
    public interface IUserServices
    {
        Task<int> AddUser(UserModel user);
        Task<IEnumerable<UserModel>> GetUserPage(int Pagesize, int PageNum);
    }
}