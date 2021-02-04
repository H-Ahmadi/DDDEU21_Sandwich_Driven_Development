using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recruitment.Domain.Recruiters
{
    public class Recruiter
    {
        private List<string> _skills;
        private List<DateTime> _availabilities;

        public long Id { get;private set; }
        public IReadOnlyList<string> Skills => _skills.AsReadOnly();
        public IReadOnlyList<DateTime> Availabilities => _availabilities.AsReadOnly();
        public string Name { get;private set; }

        public Recruiter(long id, string name, List<string> skills, List<DateTime> availabilities)
        {
            Id = id;
            Name = name;
            _skills = skills;
            _availabilities = availabilities;
        }

        public bool CanTest(List<string> candidateSkills)
        {
            return !candidateSkills.Except(this._skills).Any();
        }
        public bool IsAvailable(DateTime availability)
        {
            return _availabilities.Contains(availability);
        }

        public void Book(DateTime availability)
        {
            _availabilities.Remove(availability);
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
