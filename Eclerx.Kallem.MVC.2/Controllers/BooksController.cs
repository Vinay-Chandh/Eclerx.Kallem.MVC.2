using Eclerx.Kallem.MVC._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;


namespace Eclerx.Kallem.MVC._2.Controllers
{
    public class BooksController : Controller
    {

        private readonly ApplicationDbContext _dbContext = null;

        public BooksController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Books
        public ActionResult Index()
        {
            var books = _dbContext.Book.ToList();
            return View(books);
        }

        public ActionResult Details(int id)
        {
            var book = _dbContext.Book.Include(p => p.BookName).FirstOrDefault(p => p.BookId == id);
            if (book != null)
            {
                return View(book);
            }
            return HttpNotFound();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var categories = _dbContext.Book.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(Books book)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Book.Add(book);
                _dbContext.SaveChanges();//To reflect the changes to database
                return RedirectToAction("Index");
            }
            var categories = _dbContext.Book.ToList();
            ViewBag.Categories = categories;
            return View();
        }
    }
}