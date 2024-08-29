namespace DesignPatterns.Structural.Proxy
{
    public interface IYouTube
    {
        List<YouTubeVideo> ListVideos();
        YouTubeVideo GetVideo(string id);
    }
}
