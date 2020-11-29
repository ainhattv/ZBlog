namespace ZBlog
{
    public class Setting
    {
        public static string GithubRepo = "ainhattv/ML-StarterKit";
        public static string ArticlePrefix = "src/";
        public static string PostUri(string pageName) => $"/posts/{pageName}";

        public static string GitHubResourceApi(string repo, string prefix) => $"https://api.github.com/repos/{repo}/contents/{prefix}";
    }
}