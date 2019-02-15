using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Data
{
    public class Player
    {
        //properties
        public string Name { get; set; }
        public string Gender { get; set; }
        public int HP { get; set; }
        public int Int { get; set; }
        public int Stress { get; set; }

        //TODO: make Inventory List possible
        public List<Items> Inventory { get; set; }

        //methods
        public static void PrintInventory()
        {

        }

        public static void PrintStatus()
        {

        }



    }
}
