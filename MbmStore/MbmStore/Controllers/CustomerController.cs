using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            Customer jens = new Customer("Jens", "Jensen", "Sønderhøj 30", "8230", "Viby");
            Customer morten = new Customer("Morten", "Mortensen", "Mønderhøj 30", "8230", "Viby");
            Customer peter = new Customer("Peter", "Petersen", "Pønderhøj 30", "8230", "Viby");

            jens.addPhone("5555555");
            jens.addPhone("2323232");
            jens.BirthDate = new DateTime(1994, 2, 21);
            morten.BirthDate = new DateTime(1991, 1, 21);
            peter.BirthDate = new DateTime(1997, 2, 21);

            ViewBag.Jens = jens;
            ViewBag.Morten = morten;
            ViewBag.Peter = peter;

            return View();
        }
    }
}