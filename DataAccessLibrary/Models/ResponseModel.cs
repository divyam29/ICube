using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class ResponseModel
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
        public string SubmitterName { get; set; }
        public int Rating { get; set; }
        public int IssueId { get; set; }
        public int BidAmt { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
