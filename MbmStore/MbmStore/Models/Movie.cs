﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        
        private string director;
        public string Director

        {
            get { return director; } // read                          
        }

        // constructors
        public Movie(string title, decimal price, string imageUrl, string director, int productId) :
            base (title, price, imageUrl, productId)
        {
            
            this.director = director;
        }
    }
}