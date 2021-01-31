using System.Collections.Generic;
using System.Linq;
using Recruitment.Domain.Candidates;

namespace Recruitment.Tests.TestDoubles
{
    public class FakeCandidates : ICandidateRepository
    {
        private readonly List<Candidate> _candidates;
        public FakeCandidates()
        {
            _candidates = new List<Candidate>()
            {
                new Candidate(123, "Alex", new List<string> {".NET", "Java", "PHP", "JS" }),
                new Candidate(456, "Bob", new List<string> { "JS" }),
                new Candidate(789, "Kim", new List<string> { "Ruby" }),
            };
        }

        public Candidate FindById(long candidateId)
        {
            return _candidates.FirstOrDefault(a => a.Id == candidateId);
        }
    }
}