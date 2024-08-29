namespace DesignPatterns.Structural.Proxy
{
    public class YouTubeCachedTests
    {
        [Fact]
        public void GetVideo_ShouldReturnVideoCached()
        {
            IYouTube youTube = new YouTubeCached(new YouTube());
            youTube.GetVideo("abc123");

            var video = youTube.GetVideo("abc123");

            Assert.NotNull(video);
        }
    }
}