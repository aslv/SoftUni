using System;
using System.Collections.Generic;
using System.Threading;

namespace FallingRocks
{
    class Game
    {
        static char[] r = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        static Random rand = new Random();
        static List<Rock> rocks;
        static int playGroundWidth = 30;
        static long scores;
        public class Dwarf // singletone
        {
            private static Dwarf instance = null;
            private string body;
            private int x; // position of '('
            private Dwarf()
            {
                body = "(0)";
                x = playGroundWidth / 2 - 1;
                Print();
            }
            public static Dwarf GetInstance()
            {
                if (instance == null)
                {
                    instance = new Dwarf();
                }
                return instance;
            }
            public void MoveLeft()
            {
                if (x > 0)
                {
                    x--;
                }
            }
            public void MoveRight()
            {
                if (x < playGroundWidth - 2)
                {
                    x++;
                }
            }
            public void Print(bool hit = false)
            {
                Console.SetCursorPosition(x, Console.WindowHeight - 1);
                Console.ForegroundColor = hit ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(hit ? "XXX" : body);
            }
            public bool Overlap(Rock r)
            {
                if (Console.WindowHeight - 1 == r.y)
                {
                    if (x == r.x || x + 1 == r.x || x + 2 == r.x)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public class Rock
        {
            private char body;
            public int x, y;
            public ConsoleColor colour;
            private ConsoleColor GetRandomConsoleColor()
            {
                int r = rand.Next(16);
                switch (r)
                {
                    case 0: return ConsoleColor.White;
                    case 1: return ConsoleColor.Blue;
                    case 2: return ConsoleColor.Cyan;
                    case 3: return ConsoleColor.DarkBlue;
                    case 4: return ConsoleColor.DarkCyan;
                    case 5: return ConsoleColor.DarkGray;
                    case 6: return ConsoleColor.White;
                    case 7: return ConsoleColor.DarkGreen;
                    case 8: return ConsoleColor.DarkMagenta;
                    case 9: return ConsoleColor.DarkRed;
                    case 10: return ConsoleColor.DarkYellow;
                    case 11: return ConsoleColor.Gray;
                    case 12: return ConsoleColor.Green;
                    case 13: return ConsoleColor.Magenta;
                    case 14: return ConsoleColor.Red;
                    case 15: return ConsoleColor.Yellow;
                    default: return ConsoleColor.Black;
                }
            }
            public Rock()
            {
                body = r[rand.Next(r.Length)];
                x = rand.Next(playGroundWidth);
                y = 0;
                colour = GetRandomConsoleColor();
            }
            public bool MoveDown()
            {
                if (y < Console.WindowHeight - 1)
                {
                    y++;
                    return true;
                }
                return false;
            }
            public void Print()
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = colour;
                Console.Write(body);
            }
        }
        static void Initialisation()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.Title = "Falling Rocks";
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth = 50;
            scores = 0;
            rocks = new List<Rock>();
        }
        static void Main()
        {
            Initialisation();
            int livesCount = 3;
            Dwarf dwarf = Dwarf.GetInstance();
            List<Rock> removeObsoletes;
            bool hit = false;
            ConsoleKeyInfo pressedKey;
            while (true)
            {
                // adding new rocks
                for (int i = 0, count = rand.Next(playGroundWidth / (scores > 200 ? 7 : 10)); i < count; i++)
                {
                    rocks.Add(new Rock());
                }
                // moving our dwarf
                while (Console.KeyAvailable)
                {
                    pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow || pressedKey.Key == ConsoleKey.A) // <--
                    {
                        dwarf.MoveLeft();
                    }
                    if (pressedKey.Key == ConsoleKey.RightArrow || pressedKey.Key == ConsoleKey.D) // -->
                    {
                        dwarf.MoveRight();
                    }
                    if (pressedKey.Key == ConsoleKey.Escape) // Esc
                    {
                        Environment.Exit(0); // leave game
                    }
                }
                removeObsoletes = new List<Rock>(); // rocks, which are to leave the screen
                hit = false;
                foreach (Rock rock in rocks)
                {
                    if (!rock.MoveDown())
                    {
                        removeObsoletes.Add(rock);
                    }
                    if (dwarf.Overlap(rock)) // if hit
                    {
                        livesCount--;
                        hit = true;
                        Console.Beep();
                        if (livesCount == 0) // game over
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Out.WriteLine("GAME OVER !!!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Environment.Exit(0);
                        }
                    }
                }
                Console.Clear();
                foreach (Rock old in removeObsoletes) // removing rocks, which are to leave the screen
                {
                    rocks.Remove(old);
                    scores++;
                }
                if (hit)
                {
                    rocks.Clear();
                    scores -= 10;
                }
                // printing
                foreach (Rock rock in rocks)
                {
                    rock.Print();
                }
                dwarf.Print(hit);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(playGroundWidth + 5, 5);
                Console.Out.WriteLine("Lives: {0}", livesCount);
                Console.SetCursorPosition(playGroundWidth + 5, 7);
                Console.Out.WriteLine("Scores: {0}", scores);
                Thread.Sleep(150);
            }
        }
    }
}
