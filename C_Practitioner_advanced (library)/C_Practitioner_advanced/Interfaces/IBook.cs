using Library.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IBook
    {
        string Title { get; set; }
        string Autheur { get; set; }
        int PG { get; set; }
        bool Availability { get; set; }
        string CustomerName { get; set; }
        int TimeRented { get; set; }
        GenresBooks Genre { get; set; }
    }
}

