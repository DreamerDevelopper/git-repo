using System;

namespace _2dWalker
{
    internal class CreateMap
    {
        Random rnd = new Random();

        private int x;
        private int y;
        private string[,] map = new string[10, 20];

        public void CrMap()
        {
            x = rnd.Next(0,10);
            y = rnd.Next(0,20);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (i == x && j == y)
                        map[i, j] = "+";                    
                    else
                        map[i, j] = ".";
                }
            }
        }

        public string[,] GetMap 
        {
            get
            {
                return map;
            } 
        }
    }
}
