using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{

    public class IssueData : IIssueData
    {

        private readonly ISqlDataAccess _Issuedb;

        public IssueData(ISqlDataAccess db)
        {
            _Issuedb = db;
        }

        public Task<List<IssueModel>> GetIssues()
        {
            string sql = "select * from dbo.Issues";

            return _Issuedb.LoadData<IssueModel, dynamic>(sql, new { });
        }
		public Task<List<IssueModel>> GetIndIssues(string Name)
		{
			string sql = "select * from dbo.Issues where SubmittedBy = '" + Name + "'";

			return _Issuedb.LoadData<IssueModel, dynamic>(sql, new { });
		}

	}


}
