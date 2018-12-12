using Library.Enumerations;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : ILibrarian
    {
        private List<Book> books = new List<Book>()
            {
                new Book("The Hobbit", "Tolkien", 12, true, "", 0, GenresBooks.Sifi),
                new Book("title", "autheur", 0, true, "", 0, GenresBooks.None)
            };

        private List<Librarian> librarians = new List<Librarian>()
        {
            new Librarian1(),
            new Librarian2()
        };


        private static bool BookAvailability;
        public static string BookCustomer;
        public static string CustomerName;
        private static string NameLibrarian;
        public static bool Availability;

        public string name { get; set; }
        public string speed { get; set; }
        public int timeAway { get; set; }

        public Librarian()
        {
            //TODO; set customerName to librarian
            if (CustomerName == "")
            {
                Availability = true;
            }
            else
            {
                Availability = false;
                //TODO: set customerName to customer with lowest TimeOfEntry
            }
        }

        //standaard methodes; boek halen, boek wegzetten, interactie klant
        public static void CheckBook()
        {
            Console.WriteLine("Librarian checks for book");
            NameLibrarian = Customer.nameLibrarian;
            //for checking if book is in stock

            //TODO; bookAvalibility = availibility book in BookList;
            BookAvailability = true;

            switch (BookAvailability)
            {
                case true:
                    GetBook();
                    //TODO: set bookCustomer to BookList.Title
                    //bookCustomer = 
                    break;
                case false:
                    Customer.Exits();
                    break;
                default:
                    break;
            }
        }

        public static void GetBook()
        {
            Console.WriteLine("Librarian gets the book from the library.");
            //for getting the book and giving it to the customer
            switch (NameLibrarian)
            {
                case "Robin":
                    Librarian1.SpeedGettingBook();
                    break;
                case "Yuri":
                    Librarian2.SpeedGettingBook();
                    break;
                default:
                    break;
            }

            BookAvailability = false;
            Customer.HasBook();
            BookCustomer = "";
            Availability = true;
        }

        public static void TakeBookBack()
        {
            Console.WriteLine("Librarian takes book back to library");
            //for taking the book from the customer and taking it to the stock
        }
    }

    public class Librarian1 : Librarian
    {
        //librarian 1
        public new string speed = "fast";
        public new string name = "Robin";
        //methode voor snelheid (snel)

        public static void SpeedGettingBook()
        {
            //TODO: set timer for getting book from stock

        }
    }

    public class Librarian2 : Librarian
    {
        //librarian 2
        public new string speed = "slow";
        public new string name = "Yuri";
        //methode voor sneldheid (langzaam)

        public static void SpeedGettingBook()
        {
            //TODO: set timer for getting book from stock

        }
    }
}
