using Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public class Book :IBook
    {
        public Book(string title, string autheur, int PG, bool availability, string customerName, int timeRented, GenresBooks genre)
        {
            Title = title;
            Autheur = autheur;
            this.PG = PG;
            Availability = availability;
            CustomerName = customerName;
            TimeRented = timeRented;
            Genre = genre;
        }

        //lijst met boeken op gesorteerd op auteur
        //nodig; genre attribute

        //fields boeken; titel, auteur, genre, leeftijdsgrens, beschiktbaar(bool), naam klant(kan leeg zijn = ''), tijd weg(kan leeg zijn = 0)
        public string Title { get; set; }
        public string Autheur { get; set; }
        public int PG { get; set; }
        public bool Availability { get; set; }
        public string CustomerName { get; set; }
        public int TimeRented { get; set; }
        public GenresBooks Genre { get; set; }
    }

}


