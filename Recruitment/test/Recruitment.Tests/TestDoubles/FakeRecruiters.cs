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

        public List<Recruiter> FindRecruiterByAvailability(DateTime availability)
        {
            return _recruiters
                .Where(a => a.Availabilities.Contains(availability))
                .ToList();
        }

        public void BookAvailability(Recruiter appropriateRecruiter, DateTime availability)
        {
            var recruiters = _recruiters.Where(a => a.Id == appropriateRecruiter.Id);
            foreach (var recruiter in recruiters)
                recruiter.Availabilities.Remove(availability);
        }
    }
}
