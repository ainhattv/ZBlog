using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ZBlog.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using ZBlog.Interfaces;
using System.Linq;
using System.IO;

namespace ZBlog.Services
{
    public class GitHubService : IGitHubService
    {
        private HttpClient _client;
        public GitHubService(HttpClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<ArticleContentModel>> GetArticlesAsync(string type = null)
        {
            var api = Setting.GitHubResourceApi(Setting.GithubRepo, Setting.ArticlePrefix);
            var response = await _client.GetAsync(api);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();

                var articles = JsonSerializer.Deserialize<IEnumerable<ArticleContentModel>>(json);

                if (type != null)
                    articles = articles.Where(x => x.Type == type && CheckFileExtension(x.Name)).ToList();

                return articles;
            }
            else
            {
                return new List<ArticleContentModel>();
            }
        }

        private bool CheckFileExtension(string fileName)
        {
            var extention = Path.GetExtension(fileName);

            if (extention.ToUpper() != ".md".ToUpper())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}