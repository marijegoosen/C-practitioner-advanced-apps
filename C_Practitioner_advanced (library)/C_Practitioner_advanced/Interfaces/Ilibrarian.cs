using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface ILibrarian
    {
        string name { get; set; }
        string speed { get; set; }
        int timeAway { get; set; }
    }

}
