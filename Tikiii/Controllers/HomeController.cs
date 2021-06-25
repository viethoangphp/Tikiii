using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tikiii.Models;

namespace Tikiii.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBContext db = new DBContext();
            List<Book> list = db.Books.ToList();
            return View(list);
        }

       
    }
}