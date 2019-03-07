﻿using MbmStore.Infrastructure;
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

            List<Customer> Customers = new List<Customer>();
            Customers = Repository.Customers;

            ViewBag.Customer = Customers;

           

            return View();
        }
    }
}