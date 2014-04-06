using System;

namespace SpiralMatrix
{
    class Spiral
    {
        public enum Ward { Right, Down, Left, Up };

        public class ShowDirection
        {
            public Ward Direction { get; set; }

            public ShowDirection()
            {
                Direction = Ward.Right;
            }
            public void Inc(int times = 1)
            {
                for (int i = 0; i < times; i++)
                {
                    switch (Direction)
                    {
                        case Ward.Right: Direction = Ward.Down;
                            break;
                        case Ward.Down: Direction = Ward.Left;
                            break;
                        case Ward.Left: Direction = Ward.Up;
                            break;
                        case Ward.Up: Direction = Ward.Right;
                            break;
                    }
                }
            }
        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            ShowDirection whereTo = new ShowDirection();
            int x = 0, y = 0;
            a[x, y] = 1;
            for (int value = 2, limit = n * n; value <= limit; value++)
            {
                switch (whereTo.Direction)
                {
                    case Ward.Right:
                        {
                            if (y + 1 == n || a[x, y + 1] > 0)
                            {
                                whereTo.Inc();
                            }
                        }
                        break;
                    case Ward.Down:
                        {
                            if (x + 1 == n || a[x + 1, y] > 0)
                            {
                                whereTo.Inc();
                            }
                        }
                        break;
                    case Ward.Left:
                        {
                            if (y == 0 || a[x, y - 1] > 0)
                            {
                                whereTo.Inc();
                            }
                        }
                        break;
                    case Ward.Up:
                        {
                            if (x == 0 || a[x - 1, y] > 0)
                            {
                                whereTo.Inc();
                            }
                        }
                        break;
                }

                switch (whereTo.Direction)
                {
                    case Ward.Right: y++;
                        break;
                    case Ward.Down: x++;
                        break;
                    case Ward.Left: y--;
                        break;
                    case Ward.Up: x--;
                        break;
                }

                a[x, y] = value;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
