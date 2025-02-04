using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.SqlServices
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ISQLDataAccess _dataAccess;
        public CustomerServices(ISQLDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<CustomerModel>> GetAllCustomerPager(int PageSize, int Pagenum) => await _dataAccess.LoadData<CustomerModel, dynamic>(StoreProceduer: "Sp_GetCustomerPager", new { PageSize, Pagenum });

        public async Task<int> InsertCustomer(CustomerModel customerModel) => await _dataAccess.Savedata(storeprocedure: "Sp_InsertCustomer", new { customerModel.CustomerName, customerModel.Address1, customerModel.Address2, customerModel.Pin, customerModel.City, customerModel.State, customerModel.Country, customerModel.Email, customerModel.Phone });
    }
}
