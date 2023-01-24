using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IUserData
    {
        Task<List<UserModel>> GetUser(string email);
        Task InsertUser(UserModel person);
    }
}