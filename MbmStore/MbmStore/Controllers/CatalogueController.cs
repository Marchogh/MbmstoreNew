using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {

         IList<Book> books = new List<Book>();
         books = Repository.Products.OfType<Book>().ToList();
         ViewBag.Books = books;

         ViewBag.Products = Repository.Products;


            return View();
        }
    }
}

