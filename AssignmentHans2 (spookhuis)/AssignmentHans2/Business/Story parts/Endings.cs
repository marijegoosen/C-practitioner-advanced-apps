using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Business.Story_parts
{
    public class Endings
    {
        //general ending
        public static void GeneralEnd()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("-----       END     ------");
            Console.WriteLine("--------------------------");
        }

        //ending when leaving with Exit action or through an exit in the house
        public static void CowardExit()
        {
            
        }

        //ending when winning the game
        public static void WinnersExit()
        {
            Console.WriteLine("YOU HAVE MADE IT TO THE FINISH!");
            var str = @"╔═══╗─────────────╔╗───╔╗───╔╗
║╔═╗║────────────╔╝╚╗──║║──╔╝╚╗
║║─╚╬══╦═╗╔══╦═╦═╩╗╔╬╗╔╣║╔═╩╗╔╬╦══╦═╗╔══╗
║║─╔╣╔╗║╔╗╣╔╗║╔╣╔╗║║║║║║║║╔╗║║╠╣╔╗║╔╗╣══╣
║╚═╝║╚╝║║║║╚╝║║║╔╗║╚╣╚╝║╚╣╔╗║╚╣║╚╝║║║╠══║
╚═══╩══╩╝╚╩═╗╠╝╚╝╚╩═╩══╩═╩╝╚╩═╩╩══╩╝╚╩══╝
──────────╔═╝║
──────────╚══╝";
            Console.WriteLine(str);
            Console.WriteLine("-----------------------");
        }

    }
}
