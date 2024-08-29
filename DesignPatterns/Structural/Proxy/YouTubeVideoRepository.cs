namespace DesignPatterns.Structural.Proxy
{
    public static class YouTubeVideoRepository
    {
        public static List<YouTubeVideo> GetAllVideos()
        {
            List<YouTubeVideo> videos =
            [
                new("abc123", "Design Patterns in C#", TimeSpan.FromMinutes(10), "http://youtube.com/watch?v=abc123"),
                new("def456", "Introduction to ASP.NET Core", TimeSpan.FromMinutes(15), "http://youtube.com/watch?v=def456"),
                new("ghi789", "Entity Framework Core Tutorial", TimeSpan.FromMinutes(12), "http://youtube.com/watch?v=ghi789"),
                new("jkl012", "SOLID Principles in C#", TimeSpan.FromMinutes(8), "http://youtube.com/watch?v=jkl012"),
                new("mno345", "Dependency Injection in .NET", TimeSpan.FromMinutes(14), "http://youtube.com/watch?v=mno345")
            ];
            return videos;
        }
    }

}
