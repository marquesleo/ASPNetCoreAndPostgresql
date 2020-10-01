using Microsoft.AspNetCore.Mvc;
using ArticleApp.API.Data;
using System.Linq;

namespace ArticleApp.API.Controllers
{

    [Route("api/[Controller]")]
    [ApiController]
     public class ArticleController :ControllerBase
    {
        private DataContext _context = null;
        public ArticleController(DataContext context){
            _context = context;
        }
        public ActionResult GetArticle(){
            return Ok(_context.Articles.ToList());
        }
    }
}