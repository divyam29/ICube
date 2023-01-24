using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess _Userdb;

        public UserData(ISqlDataAccess db)
        {
            _Userdb = db;
        }

        public Task<List<UserModel>> GetUser(string email)
        {
            string sql = " select * from dbo.Users where UserName = '" + email + "'";

            return _Userdb.LoadData<UserModel, dynamic> (sql, new { });
        }

        public Task InsertUser(UserModel person)
        {
            string sql = @"insert into dbo.Users 
                           values (@OrgName, @OrgAddress, @Phone, @UserName, @Password, @Role);";

            return _Userdb.SaveData(sql, person);
        }
    }
}
