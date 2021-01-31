using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Recruiters
{
    public interface IRecruiterRepository
    {
        List<Recruiter> FindRecruiterByAvailability(DateTime availability);
        void BookAvailability(Recruiter appropriateRecruiter, DateTime availability);
    }
}