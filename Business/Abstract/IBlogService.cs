using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        List<Blog> GetAllWithCategory();
        void Add(Blog blog);
        void Delete(Blog blog);
        void Update(Blog blog);
        Blog GetById(int id);
    }
}
