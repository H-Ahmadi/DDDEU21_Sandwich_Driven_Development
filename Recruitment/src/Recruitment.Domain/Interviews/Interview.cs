using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recruitment.Domain.Candidates;
using Recruitment.Domain.Recruiters;

namespace Recruitment.Domain.Interviews
{
    public class Interview
    {
        public Candidate Candidate { get; set; }
        public Recruiter Recruiter { get; set; }
        public DateTime InterviewDate { get; set; }

        public Interview(DateTime availability, Candidate candidate, Recruiter recruiter)
        {
            this.Candidate = candidate;
            this.Recruiter = recruiter;
            this.InterviewDate = availability;
        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append("Interview{")
                .Append($"Candidate={Candidate} ,")
                .Append($"Recruiter={Recruiter} ,")
                .Append($"InterviewDate={InterviewDate} ,")
                .Append("}")
                .ToString();
        }
    }
}
