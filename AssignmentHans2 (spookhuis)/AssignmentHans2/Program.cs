using HauntedHouse.Business;
using HauntedHouse.Data;
using HauntedHouse.Enumerations;
using System;
using System.Collections.Generic;

namespace HauntedHouse
{
    public class Program
    {
        public static void Main()
        {
            var done = false;
            string answerExit;
            var game = new Game();


            game.InitializeAndStartGame();

            while (!done)
            {
                game.DescribeLocation();

                if (game.ShouldEnd()) break;

                Logos.PrintLambda();

                var input = Console.ReadLine();
                string args = "";
                if (input.Contains(" "))
                {
                    var splitted = input.Split(" ");
                    input = splitted[0];
                    args = splitted[1];
                }

                switch (input.ToLower())
                {
                    case "pick":
                        {
                            PlayerCommands.PickUp();
                            break;
                        }
                    case "status":
                        {
                            PlayerCommands.PrintStatus();
                            break;
                        }
                    case "inventory":
                        {
                            PlayerCommands.PrintInventory();
                            break;
                        }
                    case "view":
                        {
                            EViewCommands view;
                            PlayerCommands.PrintNotValidView();
                            break;
                        }
                    case "move":
                        {
                            EDirection direction;
                            if (Enum.TryParse<EDirection>(args, true, out direction))
                            {
                                game.MoveToDirection(direction);
                            }
                            else
                            {
                                PlayerCommands.PrintNotValidDirection();
                            }
                            break;
                        }
                    case "look":
                        {
                            game.LookAround();
                            break;
                        }
                    case "help":
                        {
                            PlayerCommands.PrintHelp();
                            break;
                        }
                    case "exit":
                        {
                            Console.WriteLine("Are you sure you want to quit? (y/n)");
                            Logos.PrintLambda();
                            answerExit = Console.ReadLine();
                            //TODO; set anserExit to lowercase
                            if ((answerExit == "yes") || (answerExit == "y"))
                            {
                                done = true;
                            }
                            else if ((answerExit == "no") || (answerExit == "n"))
                            {
                                Console.WriteLine("Oke, lets continue");
                            }
                            else
                            {
                                Console.WriteLine("Not a valid answer. You will continue HAHA.");
                            }
                            break;
                        }
                    default:
                        {
                            PlayerCommands.PrintCommandNotFound();
                            PlayerCommands.PrintHelp();
                            break;
                        }
                }
            }

            game.End();

            Console.WriteLine("<press any key to exit>");
            Console.ReadKey();
        }
    }
}
