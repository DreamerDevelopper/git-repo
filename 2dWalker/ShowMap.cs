using System;

namespace _2dWalker
{
    internal class ShowMap
    {
        private string[,] map;

        public void PrintMap(string[,] map)
        {
            this.map = map;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
