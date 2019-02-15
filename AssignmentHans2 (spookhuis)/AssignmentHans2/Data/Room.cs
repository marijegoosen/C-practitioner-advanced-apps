using HauntedHouse.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Data
{
    public class Room
    {
        //properties
        public IDictionary<EDirection, Room> ConnectedRooms = new Dictionary<EDirection, Room>();
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Finish { get; set; }

        public int Ghost { get; set; }


        //methods
        public void PrintInfo()
        {
            Console.WriteLine($"Currently in {Name}");
            Console.Write($"Possible directions are: ");

            foreach (var connectedRoomsKey in ConnectedRooms.Keys)
            {
                Console.Write($"{connectedRoomsKey:G} ");
            }
            Console.WriteLine();
            Console.WriteLine($"There are {Ghost} ghosts in this room.");

            Console.Write(Environment.NewLine);
        }
    }


}
