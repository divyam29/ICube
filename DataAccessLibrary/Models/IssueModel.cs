﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Models
{
    public class IssueModel
    {
        public int Id { get; set; }
        public string Heading { get; set; }
        public string Body { get; set; }
        public string SubmittedBy { get; set; }
        public int Responses { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
