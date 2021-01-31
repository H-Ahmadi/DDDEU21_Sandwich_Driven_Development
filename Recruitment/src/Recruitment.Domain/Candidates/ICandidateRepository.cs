namespace Recruitment.Domain.Candidates
{
    public interface ICandidateRepository
    {
        Candidate FindById(long candidateId);
    }
}