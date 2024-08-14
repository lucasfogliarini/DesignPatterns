namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public abstract class Support
    {
        protected Support? nextLevel;

        public void SetNextLevel(Support nextLevel)
        {
            this.nextLevel = nextLevel;
        }

        public void Resolve(Issue issue, SupportLevel levelResolved)
        {
            issue.Resolve(levelResolved);
            Console.WriteLine($"{nameof(BasicSupport)} resolved the issue: {issue.Title}");
        }

        public abstract void HandleIssue(Issue issue);
    }
}
