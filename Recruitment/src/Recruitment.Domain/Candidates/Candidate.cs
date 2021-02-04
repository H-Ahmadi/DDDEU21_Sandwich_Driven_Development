using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recruitment.Domain.Recruiters;

namespace Recruitment.Domain.Candidates
{
    public class Candidate
    {
        private List<string> _skills;
        public long Id { get;private set; }
        public string Name { get;private set; }
        public IReadOnlyList<string> Skills => _skills.AsReadOnly();

        public Candidate(long id, string name, List<string> skills)
        {
            Id = id;
            Name = name;
            _skills = skills;
        }

        public Recruiter FindAppropriateRecruiter(DateTime availability, List<Recruiter> allRecruiters)
        {
            var availableRecruiter =  allRecruiters
                .Where(recruiter => recruiter.CanTest(_skills))
                .FirstOrDefault(recruiter => recruiter.IsAvailable(availability));

            if (availableRecruiter == null) throw new RecruiterNotFoundException();
            return availableRecruiter;
        }
        public override string ToString()
        {
            return new StringBuilder()
                .Append("Candidate{")
                .Append($"Skills={string.Join(",", this.Skills)}, ")
                .Append($"Name='{Name}'")
                .Append("}")
                .ToString();
        }
    }
}
