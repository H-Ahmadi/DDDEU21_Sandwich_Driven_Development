using System;
using System.Collections.Generic;
using Recruitment.Domain.Candidates;

namespace Recruitment.Domain.Recruiters
{
    public class BookRecruiter
    {
        public Recruiter FindRecruiter(DateTime availability, Candidate candidate, IRecruiterRepository recruiters)
        {
            var allRecruiters = recruiters.FindAllRecruiters();
            var appropriateRecruiter = candidate.FindAppropriateRecruiter(availability, allRecruiters);
            appropriateRecruiter.Book(availability);
            return recruiters.UpdateRecruiter(appropriateRecruiter);
        }
    }
}