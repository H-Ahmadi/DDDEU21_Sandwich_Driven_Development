using System;
using System.Collections.Generic;
using System.Text;

namespace Recruitment.Domain.Recruiters
{
    public class Recruiter
    {
        public long Id { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
        public List<DateTime> Availabilities { get; set; } = new List<DateTime>();
        public string Name { get; set; }

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
