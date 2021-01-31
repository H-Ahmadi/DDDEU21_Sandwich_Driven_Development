using System;
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
