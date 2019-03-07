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

         List<Book> books = new List<Book>();
         books = Repository.Products.OfType<Book>().ToList();
         
         ViewBag.Products = Repository.Products;


            return View();
        }
    }
}

