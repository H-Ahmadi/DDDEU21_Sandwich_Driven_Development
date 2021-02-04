using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recruitment.Domain.Recruiters;

namespace Recruitment.Tests.TestDoubles
{
    public class FakeRecruiters : IRecruiterRepository
    {
        private readonly List<Recruiter> _recruiters;
        public FakeRecruiters()
        {
            _recruiters = new List<Recruiter>()
            {
                new Recruiter(1, "Emma", new List<string> { "PHP","JS" },  new List<DateTime> { new DateTime(2021,2,20) } ),
                new Recruiter(2, "Mary", new List<string>() { "Java",".NET", "PHP", "JS", },
                    new List<DateTime>
                    {
                        new DateTime(2021,2,20),
                        new DateTime(2021,2,22)
                    } ),
                new Recruiter(3, "John", new List<string>() { "Java", ".NET", "PHP", "JS"}, new List<DateTime> { new DateTime(2021,2,20) })
            };
        }

        public List<Recruiter> FindAllRecruiters()
        {
            return _recruiters;
        }

        public Recruiter UpdateRecruiter(Recruiter recruiter)
        {
            // update this recruiter
            return recruiter;
        }
    }
}
