using Eclerx.Kallem.MVC._2.Models;
using Eclerx.Kallem.MVC._2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Eclerx.Kallem.MVC._2.Controllers
{
            [RoutePrefix("Home")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        private IEnumerable<SelectListItem> PopulateBooks()
        {
            return _dbContext.Book.Select(c => new SelectListItem
            {
               // Value = c.Genre,
                Text = c.Genre,
            }).AsEnumerable();
        }

        public ActionResult Index()
        {
            DetailsByGenreVM detailsByGenre = new DetailsByGenreVM();
            var book = PopulateBooks();
            detailsByGenre.Genre = book;
            return View(detailsByGenre);
        }

        //[HttpGet]        
        public ActionResult GetBooks(string Genre)
        {
            DetailsByGenreVM detailsByGenre = new DetailsByGenreVM();
            var products = _dbContext.Book.Include(p => p.Genre).Where(p => p.Genre == Genre);
            detailsByGenre.books = products;

            var categories = PopulateBooks();
            detailsByGenre.Genre = categories;
            return View("Index", detailsByGenre);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}