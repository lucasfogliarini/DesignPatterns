using DesignPatterns.Behavioral.Observer;

namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class SupportUnitTests
    {
        [Fact]
        public void HandleIssues_ShouldResolveIssuesAtCorrectSupportLevel()
        {
            var issues = new List<Issue> 
            { 
                new("Simple issue", SupportLevel.Basic),
                new("Intermediate issue", SupportLevel.Advanced),
                new("Complex issue", SupportLevel.Specialized)
            };

            Support basicSupport = new BasicSupport();
            Support advancedSupport = new AdvancedSupport();
            Support specializedSupport = new SpecializedSupport();

            basicSupport.SetNextLevel(advancedSupport);
            advancedSupport.SetNextLevel(specializedSupport);

            foreach (var issue in issues)
            {
                Assert.False(issue.Resolved);
                Assert.Null(issue.LevelResolved);
                basicSupport.HandleIssue(issue);
                Assert.True(issue.Resolved);
                Assert.Equal(issue.Level, issue.LevelResolved);
            }
        }
    }
}