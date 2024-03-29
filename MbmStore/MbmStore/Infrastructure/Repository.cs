﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.Infrastructure
{
    static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        static Repository() {


            // Books
            Book b1 = new Book("Den, der lever stille", "Leonora Christina Skov", "Saxo", 2018, "9788740049428", 8, "denlever.png", 1);
            Book b2 = new Book("Solo", "Jesper Stein", "JP/Politikens Forlag", 2018, "9788740053050", 5, "solo.jpg", 2);
            Products.Add(b1);
            Products.Add(b2);

            // Music CD
            MusicCD cd1 = new MusicCD("A Night at the Opera", "Queen", "EMI", 1975, 10, "Queen_A_Night.png", 3);
            Track t1 = new Track("Death On Two Legs (Dedicated to...", "Queen", new TimeSpan(0, 2, 55));
            Track t2 = new Track("Lazing On A Sunday Afternoon", "Queen", new TimeSpan(0, 1, 45));
            Track t3 = new Track("I'm In Love With My Car", "Queen", new TimeSpan(0, 3, 35));
            Track t4 = new Track("You're My Best Friend", "Queen", new TimeSpan(0, 2, 25));
            cd1.AddTrack(t1);
            cd1.AddTrack(t2);
            cd1.AddTrack(t3);
            cd1.AddTrack(t4);
            Products.Add(cd1);

            // Movies 
            Movie m1 = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Lars", 4);
            Movie m2 = new Movie("Gladiator", 155m, "gladiator.jpg", "Ridley Scott", 5);
            Movie m3 = new Movie("Forrest Gump", 142m, "forrest-gump.jpg", "Jens", 6);
            Products.Add(m1);
            Products.Add(m2);
            Products.Add(m3);

            // Customer 
            Customer c1 = new Customer("Jens", "Jensen", "Sønderhøj 30", "8230", "Åbyhøj", 1);
            Customer c2 = new Customer("Morten", "Mortensen", "Mønderhøj 30", "8260", "Viby", 2);
            Customer c3 = new Customer("Peter", "Petersen", "Pønderhøj 30", "8000", "Aarhus", 3);
            c1.addPhone("5555555");
            c2.addPhone("2323232");
            c3.addPhone("654245245");
            c1.BirthDate = new DateTime(1994, 2, 21);
            c2.BirthDate = new DateTime(1991, 1, 21);
            c3.BirthDate = new DateTime(1994, 4, 18);
            Customers.Add(c1);
            Customers.Add(c2);
            Customers.Add(c3);

            // ORDER ITEMS
            Invoice i1 = new Invoice(488, new DateTime(2017, 6, 7), c1);
            Invoice i2 = new Invoice(1163, new DateTime(2017, 6, 11), c2);
            Invoices.Add(i1);
            Invoices.Add(i2);

            OrderItem oi1 = new OrderItem(cd1, 63);
            i1.AddOrderItem(cd1, 3);
            OrderItem oi2 = new OrderItem(m1, 74);
            i1.AddOrderItem(m1, 4);
            OrderItem oi3 = new OrderItem(b1, 101);
            i2.AddOrderItem(b1, 5);
            OrderItem oi4 = new OrderItem(b2, 105);
            i2.AddOrderItem(b2, 6);

        }

    }




   
}