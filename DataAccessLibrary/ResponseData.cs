using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ResponseData : IResponseData
    {
        private readonly ISqlDataAccess _db;

        public ResponseData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ResponseModel>> GetResponse(string id)
        {
            string sql = "select * from dbo.Responses where IssueId = '" + id + "'";

            return _db.LoadData<ResponseModel, dynamic>(sql, new { });
        }
    }
}
