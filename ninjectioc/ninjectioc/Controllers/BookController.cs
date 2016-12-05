using ninjectioc.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ninjectioc.Controllers
{
    public class BookController : Controller
    {
        IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }

        public ActionResult Index()
        {
            ViewBag.cooltitle = _book.GetCoolTitle();
            return View();
        }
    }
}