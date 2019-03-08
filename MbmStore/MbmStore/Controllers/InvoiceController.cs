using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private IEnumerable<Invoice> invoices;

        // GET: Invoice
        public ActionResult Index()
        {

            List<Invoice> invoices = new List<Invoice>();
            invoices = Repository.Invoices;

            ViewBag.Invoices = invoices;

            List<SelectListItem> customers = new List<SelectListItem>();
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.Firstname + " " +
                invoice.Customer.Lastname, Value = invoice.Customer.CustomerId.ToString() });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewBag.Invoices = Repository.Invoices;
            ViewBag.CustomerId = customers;

            return View();

        }

            [HttpPost]
            public ActionResult Index(int? CustomerId) {

            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem { Text = invoice.Customer.Firstname + " " +
                invoice.Customer.Lastname, Value = invoice.Customer.CustomerId.ToString() });
            }

            if (CustomerId != null)
            {
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == CustomerId);
            }

            ViewBag.Invoices = invoices;
            ViewBag.CustomerId = customers;

            return View();
        }
    }
}