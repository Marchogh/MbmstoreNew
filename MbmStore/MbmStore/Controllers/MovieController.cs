using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            
            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Lars");
            Movie lego = new Movie("Lego Movie 2", 150.10m, "junglebook.jpg", "Mads");
            Movie upside = new Movie("Upside", 155.10m, "junglebook.jpg", "Jens");

            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.Lego = lego;
            ViewBag.Upside = upside;


            return View();
        }
    }
}