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

        public Interview(DateTime availability, Candidate candidate, List<Recruiter> availableRecruiters, IRecruiterRepository recruiters)
        {
            var candidateSkills = candidate.Skills;
            var appropriateRecruiter = availableRecruiters
                .FirstOrDefault(a => !candidateSkills.Except(a.Skills).Any());

            if (appropriateRecruiter == null) throw new RecruiterNotFoundException();

            var recruiter = recruiters.BookAvailability(appropriateRecruiter, availability);


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
