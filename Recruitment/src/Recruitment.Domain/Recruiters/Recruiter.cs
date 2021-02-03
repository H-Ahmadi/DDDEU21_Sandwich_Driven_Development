using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recruitment.Domain.Recruiters
{
    public class Recruiter
    {
        public long Id { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<DateTime> Availabilities { get; set; } = new List<DateTime>();
        public string Name { get; set; }

        public Recruiter(long id, string name, List<string> skills, List<DateTime> availabilities)
        {
            Id = id;
            Name = name;
            Skills = skills;
            Availabilities = availabilities;
        }
        public Recruiter()
        {
            
        }

        public bool CanTest(List<string> candidateSkills)
        {
            return !candidateSkills.Except(this.Skills).Any();
        }

        public override string ToString()
        {
            return new StringBuilder()
                .Append("Recruiter{")
                .Append($"Id={Id}, ")
                .Append($"Skills={string.Join(",", this.Skills)}, ")
                .Append($"Availabilities={string.Join(",", this.Availabilities)}, ")
                .Append($"Name='{Name}'")
                .Append("}")
                .ToString();
        }
    }
}
