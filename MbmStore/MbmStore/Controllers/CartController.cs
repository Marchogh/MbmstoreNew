using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public RedirectToRouteResult AddToCart(int productId, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId ==
           productId);
            if (product != null)
            {
                GetCart().AddItem(product, 1); //add one quantity of this product
            }
            return RedirectToAction("Index", new { controller = returnUrl.Substring(1) });
        }
        public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                GetCart().RemoveItem(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        private Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

    }
}