using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tikiii.Models;

namespace Tikiii.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            DBContext db = new DBContext();
            List<Book> list = db.Books.ToList();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BookModel book)
        {
            if (ModelState.IsValid)
            {
                DBContext db = new DBContext();
                Book model = new Book();
                model.Title = book.title;
                model.Author = book.author;
                model.Price = book.price;
                model.Description = book.description;
                model.Status = 1;
                if (book.avatar != null)
                {
                    model.Avatar = "/Content/img/" + book.avatar.FileName;
                    string _FileName = Path.GetFileName(book.avatar.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Content/img/"), _FileName);
                    book.avatar.SaveAs(_path);
                    db.Books.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Book");
                }

            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            DBContext db = new DBContext();
            BookModel model = new BookModel();
            Book book = db.Books.Find(id);
            model.id = book.id;
            model.title = book.Title;
            model.author = book.Author;
            model.description = book.Description;
            model.price = (int)book.Price;
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(int id, BookModel model)
        {
            DBContext db = new DBContext();
            Book book = db.Books.Find(id);
            if (ModelState.IsValid && book != null)
            {
                book.Title = model.title;
                book.Author = model.author;
                book.Price = model.price;
                book.Description = model.description;
                db.SaveChanges();
                return RedirectToAction("Index", "Book");
            }
            return View(model);
        }
        public ActionResult Delete(int id)
        {
            DBContext db = new DBContext();
            Book book = db.Books.Find(id);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                return RedirectToAction("Index", "Book");
            }
            return HttpNotFound();

        }
    }
}