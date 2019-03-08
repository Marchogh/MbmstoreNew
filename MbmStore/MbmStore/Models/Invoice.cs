using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        private List<OrderItem> orderItems = new List<OrderItem>();

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; }
        public Customer Customer { get; set; }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItem item = new OrderItem(product, quantity);

            orderItems.Add(item);
        }

    }

}

