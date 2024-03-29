﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {

            IList<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();
            ViewBag.Movies = movies;

            ViewBag.Products = Repository.Products;


            return View();
        }
    }
}