using System.Collections.Generic;
using System.Text;

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
