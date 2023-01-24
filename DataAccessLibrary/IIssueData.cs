using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IIssueData
    {
        Task<List<IssueModel>> GetIssues();
		Task<List<IssueModel>> GetIndIssues(string Name);

	}
}