using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {

            Book denlever = new Book("Den, der lever stille", "Leonora Christina Skov", "Saxo", 2018, "9788740049428", 8, "denlever.png");
            MusicCD queen = new MusicCD("A Night at the Opera", "Queen", "EMI", 1975, 10, "Queen_A_Night.png");
            Track t1 = new Track("Death On Two Legs (Dedicated to...", "Queen", new TimeSpan(0, 2, 55)); 
            Track t2 = new Track("Lazing On A Sunday Afternoon", "Queen", new TimeSpan(0, 1, 45));
            Track t3 = new Track("I'm In Love With My Car", "Queen", new TimeSpan(0, 3, 35));
            Track t4 = new Track("You're My Best Friend", "Queen", new TimeSpan(0, 2, 25));
            queen.AddTrack(t1);
            queen.AddTrack(t2);
            queen.AddTrack(t3);
            queen.AddTrack(t4);
           
            ViewBag.Denlever = denlever;
            ViewBag.Queen = queen; 

            return View();
        }
    }
}

