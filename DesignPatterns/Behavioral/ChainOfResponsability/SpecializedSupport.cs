namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class SpecializedSupport : Support
    {
        public override void HandleIssue(Issue issue)
        {
            if (issue.Level <= SupportLevel.Specialized)
            {
                Resolve(issue, SupportLevel.Specialized);
            }
            else
            {
                nextLevel?.HandleIssue(issue);
            }
        }
    }
}
