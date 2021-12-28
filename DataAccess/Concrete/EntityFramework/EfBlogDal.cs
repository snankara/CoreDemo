using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, Context>, IBlogDal
    {
        public List<Blog> GetAllWithCategory()
        {
            using (var context = new Context())
            {
                return context.Blogs.Include(b => b.Category).ToList();
            }

        }
    }
}
