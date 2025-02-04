
namespace DataAccess
{
    public interface ISQLDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string StoreProceduer, U Parameter, string ConnectionId = "Default");
        Task<int> Savedata<T>(string storeprocedure, T Parameter, string ConnectionId = "Default");
    }
}