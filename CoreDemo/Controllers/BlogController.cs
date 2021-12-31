using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;

        public BlogController()
        {
            _blogService = new BlogManager(new EfBlogDal());
        }

        public IActionResult Index()
        {
            var blogs = _blogService.GetAllWithCategory();
            return View(blogs);
        }

        public IActionResult BlogDetails(int id)
        {
            var blog = _blogService.GetById(id);
            return View(blog);
        }
    }
}
