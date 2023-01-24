using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IResponseData
    {
        Task<List<ResponseModel>> GetResponse(string id);
    }
}