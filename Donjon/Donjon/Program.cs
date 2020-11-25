using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donjon
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sentenceWhenMoving = new Dictionary<string, string>();
            sentenceWhenMoving.Add("n", "> going to north !!!!");
            sentenceWhenMoving.Add("s", "> going to south !!!!");
            sentenceWhenMoving.Add("e", "> going to east !!!!");
            sentenceWhenMoving.Add("w", "> going to west !!!!");

            List<Dictionary<string, int>> roomsDirections = new List<Dictionary<string, int>>();
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 3 },
             { "e", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 4 },
             { "w", 0 },
             { "e", 2 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "n", 5 },
             { "w", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 0 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 1 }
            });
            roomsDirections.Add(new Dictionary<string, int>() {
             { "s", 2 }
            });

            Console.OutputEncoding = Encoding.UTF8;
            Intro();
            bool gameRunning = true;
            int room_number = 1;
            while (gameRunning)
            {
                if (room_number == 0)
                {
                    room_number = Room1(room_number, sentenceWhenMoving, roomsDirections);
                }
                else if (room_number == 1)
                {
                    room_number = Room2(room_number, sentenceWhenMoving, roomsDirections);
                }
                else if (room_number == 2)
                {
                    room_number = Room3(room_number, sentenceWhenMoving, roomsDirections);
                }
                else if (room_number == 3)
                {
                    Loose();
                    gameRunning = false;
                }
                else if (room_number == 4)
                {
                    room_number = Room4(room_number, sentenceWhenMoving, roomsDirections);
                }
                else if (room_number == 5)
                {
                    Win();
                    gameRunning = false;
                }
            }
        }

        private static void Intro()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("************ Welcome to the MAZE ************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
            Console.WriteLine("You are lost inside a Maze, try to escape...");
            Console.WriteLine("");
        }

        private static void Win()
        {
            Console.WriteLine("#######################################################################");
            Console.WriteLine("##.._|      | `-.  | `.  -_-_ _-_  _-  _- -_ -  .'|   |.'|     |  _..##");
            Console.WriteLine("##   `-.._  |    |`!  |`.  -_ -__ -_ _- _-_-  .'  |.;'   |   _.!-'|  ##");
            Console.WriteLine("##      | `-!._  |  `;!  ;. _______________ ,'| .-' |   _!.-'     |  ##");
            Console.WriteLine("##..__  |     |`-!._ | `.| |_______________||.''|  _!.;'   |     _|..##");
            Console.WriteLine("##   |``'..__ |    |`';.| -|_|           |_|'| _!-|   |   _|..-|'    ##");
            Console.WriteLine("##   |      |``--..|_ | `;!| |           | |.'    |_..!-'|     |     ##");
            Console.WriteLine("##   |      |    |   |`-,!_|_|           |_||.!-;'  |    |     |     ##");
            Console.WriteLine("##___|______|____!.,.!,.!,!| |           | |,!,.!.,.!..__|_____|_____##");
            Console.WriteLine("##      |     |    |  |  | |_|           |_|| |   |   |    |      |  ##");
            Console.WriteLine("##      |     |    |..!-;'-| |           | | |`-..|   |    |      |  ##");
            Console.WriteLine("##      |    _!.-j'  | _!,'|_|           |_||!._|  `--!.._ |      |  ##");
            Console.WriteLine("##     _!.-'|    | _.'|  !;| |           | |`.| `-._|    |``-.._  |  ##");
            Console.WriteLine("##..--'     |  _.''|  !-| !|_|           |_|.|`-. | ``._ |     |``'..##");
            Console.WriteLine("##   |      |.|    |.|  !| | |           | ||`. |`!   | `'.    |     ##");
            Console.WriteLine("##   |  _.-'  |  .'  |.' |/|_|           |_|! |`!  `,.|    |-._|     ##");
            Console.WriteLine("##  _!''|     !.'|  .'| .'|[ ]           [ ] \\|  `. | `._  |   `-._  ##");
            Console.WriteLine("##-'    |   .'   |.|  |/| /                 \\|`.  |`!    |.|      |`-##");
            Console.WriteLine("##      |_.'|   .' | .' |/                   \\  \\ |  `.  | `._-   |  ##");
            Console.WriteLine("##     .'   | .'   |/|  /                     \\ |`!   |`.|    `.  |  ##");
            Console.WriteLine("##  _.'     !'|   .' | /                       \\|  `  |  `.    |`.|  ##");
            Console.WriteLine("#######################################################################");
            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>> You found the EXIT... Congratulations:)");
            Console.ReadKey();
        }

        private static void Loose()
        {
            Console.WriteLine("                           ,--.");
            Console.WriteLine("                          {    }");
            Console.WriteLine("                          K,   }");
            Console.WriteLine("                         /  `Y`");
            Console.WriteLine("                    _   /   /");
            Console.WriteLine("                   {_'-K.__/");
            Console.WriteLine("                     `/-.__L._");
            Console.WriteLine("                     /  ' /`\\_}");
            Console.WriteLine("                    /  ' / ");
            Console.WriteLine("            ____   /  ' /");
            Console.WriteLine("     ,-'~~~~    ~~/  ' /_");
            Console.WriteLine("   ,'             ``~~~%%',");
            Console.WriteLine("  (                     %  Y");
            Console.WriteLine(" {                      %% I");
            Console.WriteLine("{      -                 %  `.");
            Console.WriteLine("|       ',                %  )");
            Console.WriteLine("|        |   ,..__      __. Y");
            Console.WriteLine("|    .,_./  Y ' / ^Y   J   )|");
            Console.WriteLine("\\           |' /   |   |   ||");
            Console.WriteLine(" \\          L_/    . _ (_,.'(");
            Console.WriteLine("  \\,   ,      ^^\"\"' / |      )");
            Console.WriteLine("    \\_  \\          /,L]     /");
            Console.WriteLine("      '-_`-,       ` `   ./`");
            Console.WriteLine("         `-(_            )");
            Console.WriteLine("             ^^\\..___,.--`");
            Console.WriteLine("");
            Console.WriteLine(">>>>>>>>>>>> It's a trap... you are DEAD :/");
            Console.ReadKey();
        }

        static int Room1(int roomId, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            Console.WriteLine("▓▓▓▓▓▓▓╣   ╠▓▓▓▓▓▓▓");
            Console.WriteLine("▓╔═════╣ n ╠═════╗▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓║       ▲       ╩╩");
            Console.WriteLine("▓║       ☻ ►     e");
            Console.WriteLine("▓║               ╦╦");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓╚═══════════════╝▓");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("There are 2 doors in your room: (n)orth, (e)ast, where do you want to go ? ");

            string choice = Console.ReadLine();
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomId];
            if (configForCurrentRoom.ContainsKey(choice))
            {
                roomId = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomId;
        }

        static int Room2(int roomId, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            Console.WriteLine("▓▓▓▓▓▓▓╣   ╠▓▓▓▓▓▓▓");
            Console.WriteLine("▓╔═════╣ n ╠═════╗▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("╩╩       ▲       ╩╩");
            Console.WriteLine(" w     ◄ ☻ ►     e");
            Console.WriteLine("╦╦               ╦╦");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓╚═══════════════╝▓");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("There are 3 doors in your room: (n)orth, (w)est, (e)ast, where do you want to go ? ");

            string choice = Console.ReadLine();
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomId];
            if (configForCurrentRoom.ContainsKey(choice))
            {
                roomId = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomId;
        }

        static int Room3(int roomId, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            Console.WriteLine("▓▓▓▓▓▓▓╣   ╠▓▓▓▓▓▓▓");
            Console.WriteLine("▓╔═════╣ n ╠═════╗▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("╩╩       ▲       ║▓");
            Console.WriteLine(" w     ◄ ☻       ║▓");
            Console.WriteLine("╦╦               ║▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓╚═══════════════╝▓");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("There are 2 doors in your room: (n)orth, (w)est, where do you want to go ? ");

            string choice = Console.ReadLine();
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomId];
            if (configForCurrentRoom.ContainsKey(choice))
            {
                roomId = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomId;
        }

        private static int Room4(int roomId, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("▓╔═══════════════╗▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓║       ☻       ║▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓║               ║▓");
            Console.WriteLine("▓╚═════╣ s ╠═════╝▓");
            Console.WriteLine("▓▓▓▓▓▓▓╣   ╠▓▓▓▓▓▓▓");
            Console.WriteLine("There are 1 door in your room: (s)outh, where do you want to go ? ");

            string choice = Console.ReadLine();
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomId];
            if (configForCurrentRoom.ContainsKey(choice))
            {
                roomId = configForCurrentRoom[choice];
                if (sentenceWhenMoving.ContainsKey(choice))
                {
                    Console.Clear();
                    Console.WriteLine(sentenceWhenMoving[choice]);
                }
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomId;
        }
    }
}
