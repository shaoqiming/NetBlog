﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.Api
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
