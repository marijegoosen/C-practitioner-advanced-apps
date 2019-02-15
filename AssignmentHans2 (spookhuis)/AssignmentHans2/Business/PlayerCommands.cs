using HauntedHouse.Business.Story_parts;
using HauntedHouse.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Business
{
    public class PlayerCommands
    {
        //result for help command
        public static void PrintHelp()
        {
            Console.WriteLine("Help:");
            Console.WriteLine("Available commands are, Move <to>, Look, Help, Exit");
        }

        //result for look command


        //result for move command

        //result for status command
        public static void PrintStatus()
        {
            Player.PrintStatus();
        }

        //result for pick command
        public static void PickUp()
        {

        }

        //result for inventory command
        public static void PrintInventory()
        {
            Player.PrintInventory();
        }
        
        //result for exit command
        public static void PrintExit()
        {
            Endings.CowardExit();
        }

        //for when an invalid direction is added
        public static void PrintNotValidDirection()
        {
            Console.WriteLine("Not a valid direction!?");
        }

        //for when an invalid view is added
        public static void PrintNotValidView()
        {
            Console.WriteLine("Not a valid view!?");
        }


        //for when an invalid command is added
        public static void PrintCommandNotFound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Command not found...");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
