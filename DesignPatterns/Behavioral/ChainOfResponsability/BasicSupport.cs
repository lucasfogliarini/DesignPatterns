namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class BasicSupport : Support
    {
        public override void HandleIssue(Issue issue)
        {
            if (issue.Level <= SupportLevel.Basic)
            {
                Resolve(issue, SupportLevel.Basic);
            }
            else
            {
                nextLevel?.HandleIssue(issue);
            }
        }
    }
}
