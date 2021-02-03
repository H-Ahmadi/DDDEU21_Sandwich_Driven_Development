using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Recruiters
{
    public interface IRecruiterRepository
    {
        List<Recruiter> FindRecruiterByAvailability(DateTime availability);
        Recruiter BookAvailability(Recruiter appropriateRecruiter, DateTime availability);
    }
}