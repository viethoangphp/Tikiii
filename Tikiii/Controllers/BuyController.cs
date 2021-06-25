using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tikiii.Models;
namespace Tikiii.Controllers
{
    public class BuyController : Controller
    {
        // GET: Buy
        public ActionResult Index(int id)
        {
            DBContext db = new DBContext();
            Book book = db.Books.Find(id);
            return View(book);
        }
    }
}