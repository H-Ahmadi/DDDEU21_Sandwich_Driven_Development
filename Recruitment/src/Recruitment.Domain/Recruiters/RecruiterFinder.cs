using System;
using System.Collections.Generic;
using System.Linq;
using Recruitment.Domain.Candidates;

namespace Recruitment.Domain.Recruiters
{
    //Domain Service
    public class RecruiterFinder
    {
        public Recruiter FindAppropriateRecruiter(DateTime availability, Candidate candidate,
            List<Recruiter> availableRecruiters, IRecruiterRepository recruiters)
        {
            var candidateSkills = candidate.Skills;
            var appropriateRecruiter = availableRecruiters
                .FirstOrDefault(availableRecruiter => availableRecruiter.CanTest(candidateSkills));

            if (appropriateRecruiter == null)  throw new RecruiterNotFoundException();

            return recruiters.BookAvailability(appropriateRecruiter, availability);
        }
    }
}