using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServices
{
    public class UserServices : IUserServices
    {
        private readonly ISQLDataAccess _dataAccess;

        public UserServices(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<UserModel>> GetUserPage(int Pagesize, int PageNum) => await _dataAccess.LoadData<UserModel, dynamic>("Sp_GetUserPager", new { Pagesize, PageNum });
        public async Task <int> AddUser(UserModel user) => await _dataAccess.Savedata(storeprocedure: "sp_InsertUser", new { user.FullName,  user.Email,  user.Phone });

    }

}
