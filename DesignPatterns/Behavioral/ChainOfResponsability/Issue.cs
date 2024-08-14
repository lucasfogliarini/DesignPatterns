namespace DesignPatterns.Behavioral.ChainOfResponsability
{
    public class Issue(string title, SupportLevel level)
    {
        public string Title { get; private set; } = title;
        public SupportLevel Level { get; private set; } = level;
        public SupportLevel? LevelResolved { get; private set; }
        public bool Resolved { get; private set; }

        public void Resolve(SupportLevel levelResolved)
        {
            LevelResolved = levelResolved;
            Resolved = true;
        }

        public override string ToString()
        {
            return Title;
        }
    }

    public enum SupportLevel
    {
        Basic = 1,
        Advanced = 2,
        Specialized = 3,
    }
}
