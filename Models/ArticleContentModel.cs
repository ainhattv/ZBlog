using System.Text.Json.Serialization;

namespace ZBlog.Models
{
    public class ArticleContentModel
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("sha")]
        public string Sha { get; set; }

        [JsonPropertyName("size")]
        public double Size { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }


        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonPropertyName("git_url")]
        public string GitUrl { get; set; }

        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }


        [JsonPropertyName("_links")]
        public ArticleLink Links { get; set; }
    }
}