﻿using Shaoqi.Blog.Api;
using Shaoqi.Blog.Core;
using Shaoqi.Blog.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shaoqi.Blog.DA
{
    public class UserDa: BlogRepository<User>
    {
        public UserDa(IUnitOfData dbContext)
            : base(dbContext)
        {
        }
    }
}
