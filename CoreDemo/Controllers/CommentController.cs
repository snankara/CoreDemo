using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController()
        {
            _commentService = new CommentManager(new EfCommentDal());
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult PartialCommentList(int id = 1)
        {
            var comments = _commentService.GetAllByBlogId(id);
            return PartialView(comments);
        }
    }
}
