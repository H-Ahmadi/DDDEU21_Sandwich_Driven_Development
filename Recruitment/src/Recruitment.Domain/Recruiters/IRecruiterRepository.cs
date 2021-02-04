using System;
using System.Collections.Generic;

namespace Recruitment.Domain.Recruiters
{
    public interface IRecruiterRepository
    {
        List<Recruiter> FindAllRecruiters();
        Recruiter UpdateRecruiter(Recruiter recruiter);
    }
}