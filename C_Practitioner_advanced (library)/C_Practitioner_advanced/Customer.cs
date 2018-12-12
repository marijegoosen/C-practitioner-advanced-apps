using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Customer
    {
        public static int numberOfCustomers = 0;
        private static int timeOfEntry;
        private static string book;
        public static string nameLibrarian;

        public string Name { get; set; }
        public int Age { get; set; }
        public int WaitingTime { get; set; }


        public Customer(string _name, int _age, string _book, int _waitingTime, int _timeOfEntry)
        {
            Name = _name;
            Age = _age;
            book = _book;
            WaitingTime = _waitingTime;
        }

        public static void Enters()
        {
            numberOfCustomers = numberOfCustomers + 1;
            timeOfEntry = numberOfCustomers;

            Console.WriteLine("Customer enters.");

            //TODO; set availablity of librarian(s)
            bool AvailableLibrarian = true;
            Console.WriteLine("Number of customers: " + numberOfCustomers);

            switch (AvailableLibrarian)
            {
                case true:
                    //TODO: set librarian to customer
                    AskBook();
                    break;
                case false:
                    WaitForLibrarian();
                    break;
                default:
                    break;
            }
        }

        public static void WaitForLibrarian()
        {
            Console.WriteLine("Customer waits for a book.");
            //for when the customer waits for the librarian(s) to be available
        }

        public static void AskBook()
        {
            Console.WriteLine("Customer asks for a book.");
            //librarian method for checking if book is available


            //TODO; set book title for Librarian to search (choose random from BookList)
            Librarian.CheckBook();
        }

        public static void HasBook()
        {
            Console.WriteLine("Customer takes book.");
            book = Librarian.BookCustomer;
            Exits();
        }

        public static void BringBook()
        {
            Console.WriteLine("Customer brings book back.");
            //gives book to librarian

            //librarian brings book back to stock

            //customer leaves
        }

        public static void Exits()
        {

            numberOfCustomers = numberOfCustomers - 1;
            nameLibrarian = "";

            Console.WriteLine("Customer leaves.");
            Console.WriteLine("Number of customers: " + numberOfCustomers);
            Console.WriteLine();
            Console.WriteLine();

            if (book != "")
            {
                BorrowedBook();
            }
        }

        public static void BorrowedBook()
        {
            Console.WriteLine("Customer borrowed a book.");
            //TODO; timer for how long the book is away
            //after timer = 0, BringBook method

            BringBook();
        }

    }
}
