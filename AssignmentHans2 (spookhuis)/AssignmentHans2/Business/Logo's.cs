using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Business
{
    public class Logos
    {
        //logo for the whole game
        public static void LogoGame()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("------------------------------------------------------------------------------");
            Console.Write("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ghost House");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------------------------------------------------------");

            var str = @"                         __...---""""""---...__
           .:::::.   _.-'                      '-._
       .::::::::::::::::'   ^^      ,              '-.
  .  .:::''''::::::::'   ,        _/(_       ^^       '.
   ':::'      .'       _/(_       {\\               ,   '.
             /         {\\        /;_)            _/(_    \
            /   ,      /;_)    =='/ <===<<<       {\\      \
           /  _/(_  =='/ <===<<<  \__\       ,    /;_)      \
          /   {\\      \__\      , ``      _/(_=='/ <===<<<  \ ";

            Console.WriteLine(str);
            Console.WriteLine("------------------------------------------------------------------------------");
        }

        //logo for the player

        //logo for the ghosts

        //logo for print lambda
        public static void PrintLambda()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("λ ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
