using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Recruitment.Domain.Recruiters;

namespace Recruitment.Domain.Candidates
{
    public class Candidate
    {
        public long Id { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public string Name { get; set; }
        public Candidate(long id, string name, List<string> skills)
        {
            Id = id;
            Name = name;
            Skills = skills;
        }

        public Recruiter FindAppropriateRecruiter(DateTime availability, List<Recruiter> allRecruiters)
        {
            var availableRecruiter =  allRecruiters
                .Where(recruiter => recruiter.CanTest(Skills))
                .FirstOrDefault(recruiter => recruiter.IsAvailable(availability));

            if (availableRecruiter == null) throw new RecruiterNotFoundException();
            return availableRecruiter;
        }
        public Candidate()
        {
            
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
