using Shaoqi.Blog.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shaoqi.Blog.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public String Index()
        {
            UserService Service = new UserService();
            Service.Add();
            return "";
        }
    }
}