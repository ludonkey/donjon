using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donjon
{
    class Program
    {
        static int Room1(int roomId)
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
            if (choice == "n")
            {
                Console.Clear();
                Console.WriteLine("> going to north...");
                roomId = 4;
            }
            else if (choice == "e")
            {
                Console.Clear();
                Console.WriteLine("> going to east...");
                roomId = 2;
            }
            else
            {
                Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
            }
            return roomId;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*********************************************");
            Console.WriteLine("************ Welcome to the MAZE ************");
            Console.WriteLine("*********************************************");
            Console.WriteLine("");
            Console.WriteLine("You are lost inside a Maze, try to escape...");
            Console.WriteLine("");
            bool gameRunning = true;
            int room_number = 2;
            while (gameRunning)
            {
                if (room_number == 1)
                {
                    room_number = Room1(room_number);
                }
                else if (room_number == 2)
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
                    if (choice == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to north...");
                        room_number = 5;
                    }
                    else if (choice == "w")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to west...");
                        room_number = 1;
                    }
                    else if (choice == "e")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to east...");
                        room_number = 3;
                    }
                    else
                    {
                        Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
                    }
                }
                else if (room_number == 3)
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
                    if (choice == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to north...");
                        room_number = 6;
                    }
                    else if (choice == "w")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to west...");
                        room_number = 2;
                    }
                    else
                    {
                        Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
                    }
                }
                else if (room_number == 4)
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
                    gameRunning = false;
                }
                else if (room_number == 5)
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
                    if (choice == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("> going to north...");
                        room_number = 2;
                    }
                    else
                    {
                        Console.WriteLine("THIS CHOICE DOESN'T EXIST!");
                    }
                }
                else if (room_number == 6)
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
                    gameRunning = false;
                }
            }
        }
    }
}
