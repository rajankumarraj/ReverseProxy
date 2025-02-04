using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SQLDataAccess : ISQLDataAccess
    {
        private readonly IConfiguration _configurattion;
        public SQLDataAccess(IConfiguration configuration)
        {
            _configurattion = configuration;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string StoreProceduer, U Parameter, string ConnectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_configurattion.GetConnectionString(ConnectionId));
            return await connection.QueryAsync<T>(StoreProceduer, Parameter, commandType: CommandType.StoredProcedure);
        }
        public async Task<int> Savedata<T>(string storeprocedure, T Parameter, string ConnectionId = "Default")
        {
            IDbConnection connection = new SqlConnection(_configurattion.GetConnectionString(ConnectionId));
            return await connection.ExecuteAsync(storeprocedure, Parameter, commandType: CommandType.StoredProcedure);
             

        }
    }
}
