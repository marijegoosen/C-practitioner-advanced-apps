using HauntedHouse.Business;
using HauntedHouse.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HauntedHouse.Data
{
    public class Game
    {
        private Room _currentRoom;


        public string PlayerName { get; private set; }

        public void InitializeAndStartGame()
        {
            Setup();

            Initialize();

            Start();
        }

        private void Setup()
        {
            var entrance = new Room { Description = "Main entrance to the Castle", Name = "Entrance", Ghost = 3 };
            var livingRoom = new Room { Description = "Welcome to the LivingRoom", Name = "LivingRoom", Ghost = 1};
            var diner = new Room { Description = "The diner looks nice, doesn't it?", Name = "Diner", Ghost = 1};
            var kitchen = new Room { Description = "We have some food in the kitchen.", Name = "Kitchen", Ghost = 2};
            var downBathroom = new Room { Description = "This is the downstairs bathroom.", Name = "Downstairs bathroom", Ghost = 1 };

            var upstairs = new Room { Description = "This is upstairs", Name = "Upstairs", Ghost = 2};
            var mbedroom = new Room { Description = "This is the master bedroom.", Name = "Master bedroom", Ghost = 2 };
            var upBathroom = new Room { Description = "This is the upstairs bathroom.", Name = "Upstairs bathroom", Ghost = 1 };

            var yard = new Room { Description = "This is the yard.", Name = "Yard", Ghost = 3};
            var shed = new Room { Description = "This is the tool shed", Name = "Shed" };

            var door = new Room { Description = "You reached a door!!!", Name = "Door", Finish = true};
            var window = new Room { Description = "You reached a window!!!", Name = "Window", Finish = true};
            var finish = new Room { Description = "You have left the house.", Name = "Exit", Finish = true };

            entrance.ConnectedRooms.Add(EDirection.North, livingRoom);
            entrance.ConnectedRooms.Add(EDirection.South, yard);
            entrance.ConnectedRooms.Add(EDirection.West, downBathroom);
            entrance.ConnectedRooms.Add(EDirection.East, door);

            livingRoom.ConnectedRooms.Add(EDirection.Up, upstairs);
            livingRoom.ConnectedRooms.Add(EDirection.East, diner);
            livingRoom.ConnectedRooms.Add(EDirection.South, entrance);

            diner.ConnectedRooms.Add(EDirection.North, kitchen);
            diner.ConnectedRooms.Add(EDirection.West, livingRoom);

            kitchen.ConnectedRooms.Add(EDirection.North, door);
            kitchen.ConnectedRooms.Add(EDirection.South, diner);

            downBathroom.ConnectedRooms.Add(EDirection.East, entrance);

            upstairs.ConnectedRooms.Add(EDirection.Down, livingRoom);
            upstairs.ConnectedRooms.Add(EDirection.East, mbedroom);
            upstairs.ConnectedRooms.Add(EDirection.North, upBathroom);

            mbedroom.ConnectedRooms.Add(EDirection.West, upstairs);
            mbedroom.ConnectedRooms.Add(EDirection.South, window);

            upBathroom.ConnectedRooms.Add(EDirection.South, upstairs);

            yard.ConnectedRooms.Add(EDirection.North, entrance);
            yard.ConnectedRooms.Add(EDirection.West, shed);

            shed.ConnectedRooms.Add(EDirection.East, yard);

            _currentRoom = entrance;
        }

        private void Initialize()
        {
            Logos.LogoGame();
  
            SetPlayerName();
        }

        private void SetPlayerName()
        {
            Logos.PrintLambda();

            Console.WriteLine("What are you called?");
            PlayerName = Console.ReadLine();

            while (PlayerName == "")
            {
                Logos.PrintLambda();
                Console.WriteLine("I'm sorry, I did not get that. Can you repeat your name?");
                PlayerName = Console.ReadLine();
            }
            Logos.PrintLambda();
            Console.WriteLine($"Hello {PlayerName}! Lets get started.");
            Console.WriteLine("Press any key to start.");
            var start = Console.ReadLine();

            Console.Clear();
        }

        public bool ShouldEnd()
        {
            return _currentRoom.Finish;
        }

        private void Start()
        {
            Console.WriteLine("A while ago, you got a letter from a long lost uncle. In this letter, your uncle states you inherited his house.");
            Console.WriteLine("There was one catch: you had to get all the ghosts out of his house first.");
            Console.WriteLine();
            Console.WriteLine("The point of this game is either to defeat all the ghosts or to get out one of the doors.");
            Console.WriteLine("Good luck. You are going to need it. WHAHAHAHAHAHAHAHAHAHA!!!!!!!!!");
            Console.WriteLine();
            Console.WriteLine();
        }

        public void DescribeLocation()
        {
            Console.WriteLine($"-- You are currently in {_currentRoom.Name}. --");
            Console.WriteLine($"-- {_currentRoom.Description}");
            Console.WriteLine($"-- There are {_currentRoom.Ghost} ghosts in this room. --");

            if (_currentRoom.Finish)
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

        public void MoveToDirection(EDirection direction)
        {
            var validDirection = _currentRoom.ConnectedRooms.TryGetValue(direction, out Room room); //geeft bool terug
            if (validDirection == true)
            {
                var result = _currentRoom.ConnectedRooms[direction]; //geeft room terug
                var lastRoom = _currentRoom;
                _currentRoom = result;

 //               if ((_currentRoom.Name == "Door") || (_currentRoom.Name == "Window"))
 //              {
 //                   Console.WriteLine("You found a way out!!");
 //                   Console.WriteLine($"There are still ghosts in the house. Do you want to leave? (y/n)");
//
 //                   var answer = Console.ReadLine();
 //                   if ((answer == "yes") || (answer == "y"))
 //                   {
 //                       Console.WriteLine("You are a coward.");
 //                   }
 //                   else if ((answer == "no") || (answer == "n"))
 //                   {
 //                       Console.WriteLine("Choose a different direction.");
 //                   }
 //               }

                Console.Clear();
                Logos.LogoGame();

                switch (direction)
                {
                    case EDirection.North:
                        direction = EDirection.South;
                        break;
                    case EDirection.East:
                        direction = EDirection.West;
                        break;
                    case EDirection.South:
                        direction = EDirection.North;
                        break;
                    case EDirection.West:
                        direction = EDirection.East;
                        break;
                    case EDirection.Up:
                        direction = EDirection.Down;
                        break;
                    case EDirection.Down:
                        direction = EDirection.Up;
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"-- You came from the {lastRoom.Name} from {direction} direction. --");
            }
            else
            {
                Console.WriteLine("You walked into a wall. Try again");
                Console.WriteLine();
            }
        }

        public void LookAround()
        {
            _currentRoom.PrintInfo();
        }

        public void End()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("-----       END     ------");
            Console.WriteLine("--------------------------");
        }
    }
}
