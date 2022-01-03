using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        private readonly ICommentService _commentService;

        public CommentListByBlog()
        {
            _commentService = new CommentManager(new EfCommentDal());
        }

        public IViewComponentResult Invoke(int id)
        {
            var comments = _commentService.GetAllByBlogId(id);
            return View(comments);
        }
    }
}
