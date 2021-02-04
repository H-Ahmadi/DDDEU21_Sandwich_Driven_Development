using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Domain.Candidates;
using Recruitment.Domain.Interviews;
using Recruitment.Domain.Recruiters;

namespace Recruitment.Application
{
    public class PlanInterview
    {
        private readonly ICandidateRepository _candidates;
        private readonly IRecruiterRepository _recruiters;
        private readonly IInterviewRepository _interviews;

        public PlanInterview(ICandidateRepository candidates, IRecruiterRepository recruiters, IInterviewRepository interviews)
        {
            _candidates = candidates;
            _recruiters = recruiters;
            _interviews = interviews;
        }
        public Interview Plan(long candidateId, DateTime availability)
        {
            var candidate = _candidates.FindById(candidateId);
            var recruiter = new BookRecruiter().FindRecruiter(availability, candidate, _recruiters);
            var interview = new Interview(availability, candidate, recruiter);

            _interviews.Save(interview);
            return interview;
        }
    }
}
