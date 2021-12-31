﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAllByBlogId(int id);
        void Add(Comment comment);
    }
}
