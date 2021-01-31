using System;
using System.Collections.Generic;
using ApprovalTests.Reporters;
using ApprovalTests.Reporters.TestFrameworks;
using Recruitment.Application;
using Recruitment.Domain.Candidates;
using Recruitment.Domain.Interviews;
using Recruitment.Domain.Recruiters;
using Recruitment.Tests.TestDoubles;
using Xunit;

namespace Recruitment.Tests
{
    [UseReporter(typeof(XUnit2Reporter))]
    public class PlanInterviewShould
    {
        private readonly ICandidateRepository _candidates;
        private readonly IInterviewRepository _interviews;
        private readonly IRecruiterRepository _recruiters;
        public PlanInterviewShould()
        {
            _candidates = new FakeCandidates();
            _interviews = new FakeInterviews();
            _recruiters = new FakeRecruiters();
        }

        [Fact]
        public void find_first_available_recruiter_who_can_test_candidate()
        {
            ApprovalTests.Combinations.CombinationApprovals.VerifyAllCombinations(
                PlanInterview,
                new List<long>() { 123, 456, 789, 10000, 20000, 30000 },
                new List<DateTime>()
                {
                    new DateTime(2021, 02, 20),
                    new DateTime(2021, 02, 21),
                    new DateTime(2021, 02, 22),
                }
            );
        }

        private Interview PlanInterview(long candidateId, DateTime availability)
        {
            var planner = new PlanInterview(_candidates, _recruiters, _interviews);
            return planner.Plan(candidateId, availability);
        }
    }
}
