using System;

namespace _2dWalker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreateMap createMap = new CreateMap();
            createMap.CrMap();

            ShowMap showMap = new ShowMap();
            
            Move move = new Move(createMap.GetMap);

            bool checker = true;
            while (true)
            {

                if (checker)
                {
                    showMap.PrintMap(createMap.GetMap);
                    checker = false;
                }

                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    move.RefreshMap(key);
                    showMap.PrintMap(move.GetMap);
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    move.RefreshMap(key);
                    showMap.PrintMap(move.GetMap);
                }
                else if (key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    move.RefreshMap(key);
                    showMap.PrintMap(move.GetMap);
                }
                else if (key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    move.RefreshMap(key);
                    showMap.PrintMap(move.GetMap);
                }
                else if (key == ConsoleKey.Escape)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    showMap.PrintMap(move.GetMap);
                    continue;
                }

            }
        }
    }
}
