namespace DesignPatterns.Structural.Proxy
{
    public class YouTubeCached(IYouTube youtube) : IYouTube
    {
        private List<YouTubeVideo> _listVideosCached;
        private List<YouTubeVideo> _videosCached = [];

        public List<YouTubeVideo> ListVideos()
        {
            _listVideosCached ??= youtube.ListVideos();
            return _listVideosCached;
        }
        public YouTubeVideo GetVideo(string id)
        {
            var videoCached = _videosCached.FirstOrDefault(x => x.Id == id);
            if (videoCached == null)
            {
                videoCached = youtube.GetVideo(id);                
                _videosCached.Add(videoCached);
            }
            return videoCached;
        }
    }
}