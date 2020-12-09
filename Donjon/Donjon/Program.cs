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
                if (room_number == 3)
                {
                    Loose();
                    gameRunning = false;
                }
                else if (room_number == 5)
                {
                    Win();
                    gameRunning = false;
                } else
                {
                    room_number = Room(room_number, sentenceWhenMoving, roomsDirections);
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

        static void DisplayStandardRoom(Dictionary<string, int> configForCurrentRoom)
        {
            bool canGoNorth = configForCurrentRoom.ContainsKey("n");
            bool canGoSouth = configForCurrentRoom.ContainsKey("s");
            bool canGoEast = configForCurrentRoom.ContainsKey("e");
            bool canGoWest = configForCurrentRoom.ContainsKey("w");
            Console.WriteLine("");
            generateRoom(canGoNorth, canGoSouth, canGoEast, canGoWest);
            Console.WriteLine("");
            Console.Write("There are " + configForCurrentRoom.Count() + " door(s) in your room: ");
            if (canGoNorth)
                Console.Write("(n)orth ");
            if (canGoSouth)
                Console.Write("(s)outh ");
            if (canGoEast)
                Console.Write("(e)ast ");
            if (canGoWest)
                Console.Write("(w)est ");
            Console.WriteLine("where do you want to go ? ");
        }

        static void generateRoom(bool canGoNorth, bool canGoSouth, bool canGoEast, bool canGoWest)
        {
            for (int y = 0; y < 7; y++)
            {
                string currentTextLine = "";
                for (int x = 0; x < 17; x++)
                {
                    bool isInside = x > 0 && x < 16 && y > 0 && y < 6;
                    bool northDoor = canGoNorth && x == 8 && y == 0;
                    bool southDoor = canGoSouth && x == 8 && y == 6;
                    bool eastDoor = canGoEast && x == 16 && y == 3;
                    bool westDoor = canGoWest && x == 0 && y == 3;
                    bool isDoor = northDoor || southDoor || eastDoor || westDoor;
                    bool isPlayer = x == 8 && y == 3;

                    if (isPlayer)
                    {
                        currentTextLine += "☻";
                    }
                    else if (isInside || isDoor)
                    {
                        currentTextLine += " ";
                    }
                    else
                    {
                        currentTextLine += "#";
                    }
                }
                Console.WriteLine(currentTextLine);
            }
        }

        static int Room(int roomId, Dictionary<string, string> sentenceWhenMoving, List<Dictionary<string, int>> roomsDirections)
        {
            Dictionary<string, int> configForCurrentRoom = roomsDirections[roomId];
            DisplayStandardRoom(configForCurrentRoom);
            string choice = Console.ReadLine();

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
