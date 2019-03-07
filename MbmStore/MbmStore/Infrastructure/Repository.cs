using System;
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
            Book b1 = new Book("Den, der lever stille", "Leonora Christina Skov", "Saxo", 2018, "9788740049428", 8, "denlever.png");
            Book b2 = new Book("Book2", "Christina Skov", "Saxi", 2007, "9788740049428", 5, "denlever.png");
            Products.Add(b1);
            Products.Add(b2);

            // Music CD
            MusicCD cd1 = new MusicCD("A Night at the Opera", "Queen", "EMI", 1975, 10, "Queen_A_Night.png");
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
            Movie m1 = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Lars");
            Movie m2 = new Movie("Lego Movie 2", 150.10m, "junglebook.jpg", "Mads");
            Movie m3 = new Movie("Upside", 155.10m, "junglebook.jpg", "Jens");
            Products.Add(m1);
            Products.Add(m2);
            Products.Add(m3);


            // Customer 
            Customer c1 = new Customer("Jens", "Jensen", "Sønderhøj 30", "8230", "Viby");
            Customer c2 = new Customer("Morten", "Mortensen", "Mønderhøj 30", "8230", "Viby");
            Customer c3 = new Customer("Peter", "Petersen", "Pønderhøj 30", "8230", "Viby");
            c1.addPhone("5555555");
            c1.addPhone("2323232");
            c1.BirthDate = new DateTime(1994, 2, 21);
            c2.BirthDate = new DateTime(1991, 1, 21);
            
            


        }

    }




   
}