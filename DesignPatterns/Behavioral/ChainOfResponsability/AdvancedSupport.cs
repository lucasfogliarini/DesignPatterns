namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class AdvancedSupport : Support
    {
        public override void HandleIssue(Issue issue)
        {
            if (issue.Level <= SupportLevel.Advanced)
            {
                Resolve(issue, SupportLevel.Advanced);
            }
            else
            {
                nextLevel?.HandleIssue(issue);
            }
        }
    }
}
