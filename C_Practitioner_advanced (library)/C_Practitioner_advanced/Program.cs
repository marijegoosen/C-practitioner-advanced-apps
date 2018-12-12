using Library.Enumerations;
using Library.Interfaces;
using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {    
            /*nodig; 3 classes (boeken, klanten, librarian)
             * boeken gesorteerd op auteur en genre (genre is attribute)
             * boeken worden uitgeleend op naam klant voor tijd
             * klanten krijgen een tijd van lenen (timer) en brengen daarna boek terug
             * librarian is link tussen boeken en klanten
             * 
             * maak lijst van klanten die boek geleend hebben en wanneer die terugkomen
             * maak lijst van boeken die geleend zijn
             * maak lijst van klanten die wachten 
             * 
             * fields klanten; naam, leeftijd
             * fields librarian; naam, snelheid, beschikbaar (bool), tijd weg (kan leeg zijn), boek (kan leeg zijn), klant (kan leeg zijn)
             */

            //customer enters and asks for a book
            Customer.Enters();


            Console.Read();
        }
    }
}
