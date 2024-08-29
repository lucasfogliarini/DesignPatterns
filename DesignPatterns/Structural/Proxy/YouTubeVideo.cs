namespace DesignPatterns.Structural.Proxy
{
    public class YouTubeVideo(string id, string title, TimeSpan duration, string url)
    {
        public string Id { get; private set; } = id;
        public string Title { get; private set; } = title;
        public TimeSpan Duration { get; private set; } = duration;
        public string Url { get; private set; } = url;
    }
}