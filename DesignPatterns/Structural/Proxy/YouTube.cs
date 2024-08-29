namespace DesignPatterns.Structural.Proxy
{
    public class YouTube : IYouTube
    {
        public List<YouTubeVideo> ListVideos()
        {
            Console.WriteLine("Enviando uma solicitação para listar vídeos do YouTube...");
            return YouTubeVideoRepository.GetAllVideos();
        }
        public YouTubeVideo GetVideo(string id)
        {
            Console.WriteLine($"Obtendo informações do vídeo {id}...");
            var video = YouTubeVideoRepository.GetAllVideos().FirstOrDefault(v=>v.Id == id);
            return video;
        }
    }
}