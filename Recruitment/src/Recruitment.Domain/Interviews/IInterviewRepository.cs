using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Domain.Interviews
{
    public interface IInterviewRepository
    {
        void Save(Interview interview);
    }
}
