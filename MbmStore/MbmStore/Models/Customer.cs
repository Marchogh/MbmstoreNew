using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{


    public class Customer
    {

        // Field
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public int age { get; set; }
        public int CustomerId { get; set; }

        List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;
        DateTime now = DateTime.Now;
       
        // Prop
        public List<string> PhoneNumbers { 
            get { return phoneNumbers; }
        }
        public DateTime BirthDate
        {
            set
            {
                birthDate = value;

               if ((DateTime.Now.Year - value.Year) > 120 || (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age not accepted");
                }
            }
            get
            {
                return birthDate;
            }
        }
    

        public int Age
         {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }
                return age;
            }
         }

      
        // Constructor 
        public Customer(string firstname, string lastname, string address, string zip, string city, int customerid)
        {
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city;
            CustomerId = customerid;
        }

        // Method 
        public void addPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }
    }

}