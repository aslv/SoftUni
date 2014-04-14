using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_12___Falling_Rocks
{
    class FallingRocksGame
    {
        struct Position
        {
            public int x, y;
            public Position(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        // ROCKS

        private static List<Position> MakeArrayForRocks()   // makes position for the current rock
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            List<Position> rocks = new List<Position>();
            for (int i = 0; i < randomGenerator.Next(2, 7); i++)
            {
                rocks.Add(new Position
                    (randomGenerator.Next(1, Console.WindowWidth - 1),
                    randomGenerator.Next(1, Console.WindowHeight - 13)));
            }
            return rocks;
        }

        private static void PrintRock(List<Position> rocks, string rock)    // Print rocks with color and symbol
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            ConsoleColor[] colors = 
            {
                ConsoleColor.Yellow,
                ConsoleColor.DarkGreen,
                ConsoleColor.Cyan,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Red,
                ConsoleColor.Gray
            };
            for (int i = 0; i < rocks.Count; i++)
            {
                Console.SetCursorPosition(rocks[i].x, rocks[i].y);
                Console.ForegroundColor = colors[randomGenerator.Next(0, colors.Length)];
                Console.Write(rock);
            }
        }

        static void Main(string[] args)
        {
            // Console Settings

            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            //use for determin the time you survive
            DateTime startingTime = DateTime.Now;
            // The speed of the game
            double sleepTime = 50;

            // dwarf implementation

            Position dwarf = new Position(39, 24);
            Console.SetCursorPosition(dwarf.x, dwarf.y);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("0");
            Console.SetCursorPosition(dwarf.x + 1, dwarf.y);
            Console.Write(")");
            Console.SetCursorPosition(dwarf.x - 1, dwarf.y);
            Console.Write("(");

            // ROCKS

            List<Position> plusRocks = MakeArrayForRocks();
            PrintRock(plusRocks, "+");
            List<Position> upperRocks = MakeArrayForRocks();
            PrintRock(upperRocks, "^");
            List<Position> maimunRocks = MakeArrayForRocks();
            PrintRock(maimunRocks, "@");
            List<Position> multyRocks = MakeArrayForRocks();
            PrintRock(multyRocks, "*");
            List<Position> andRocks = MakeArrayForRocks();
            PrintRock(andRocks, "&");
            List<Position> procentRocks = MakeArrayForRocks();
            PrintRock(procentRocks, "%");
            List<Position> moneyRocks = MakeArrayForRocks();
            PrintRock(moneyRocks, "$");
            List<Position> sharpRocks = MakeArrayForRocks();
            PrintRock(sharpRocks, "#");
            List<Position> minusRocks = MakeArrayForRocks();
            PrintRock(minusRocks, "-");
            List<Position> exclamationRocks = MakeArrayForRocks();
            PrintRock(exclamationRocks, "!");
            List<Position> dotRocks = MakeArrayForRocks();
            PrintRock(dotRocks, ".");
            List<Position> dotSlashRocks = MakeArrayForRocks();
            PrintRock(dotSlashRocks, ";");


        }
    }
}
