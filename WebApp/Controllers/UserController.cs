using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using (CodeFirstDbContext db = new CodeFirstDbContext())
            {
                var userList = db.User.ToList().Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    Username = u.Username,
                    Password = u.Password,
                    Name = u.Name,
                });
                return View(userList);
            }
        }
    }
}