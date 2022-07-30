using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Articles : ControllerBase
    {
        public Articles()
        {

        }
        public IEnumerable<ArticleView> GetArticles()
        {
            throw new NotImplementedException();
        }

        public bool DeleteArticle (int id)
        {
            throw new NotImplementedException();
        }
    }
}
