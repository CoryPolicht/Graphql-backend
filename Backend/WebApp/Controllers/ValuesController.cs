using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Articles : ControllerBase
    {
        public IEnumerable<ArticleView> GetArticles()
        {

        }

        public bool DeleteArticle (int id)
        {

        }
    }
}
