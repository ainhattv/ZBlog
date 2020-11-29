using System.Collections.Generic;
using System.Threading.Tasks;
using ZBlog.Models;

namespace ZBlog.Interfaces
{
    public interface IGitHubService
    {
        Task<IEnumerable<ArticleContentModel>> GetArticlesAsync(string type = null);
        // Task<ArticleContentModel> GetArticleAsync(string fileName);
    }
}