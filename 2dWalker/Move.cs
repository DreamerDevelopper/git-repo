using System;
using System.Security.Permissions;

namespace _2dWalker
{
    internal class Move
    {
        private string[,] map;
        private ConsoleKey key;
        private bool checker;

        
        public Move(string[,] map)
        {
            this.map = map;
        }

        public Move(ConsoleKey key)
        {
            this.key = key;
        }

        public string[,] GetMap 
        {
            get
            {
                return map;
            } 
        }

        public void RefreshMap(ConsoleKey key)
        {
            checker = false;

            this.key = key;

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i,j] == "+")
                    {
                        checker = true;
                        if (this.key == ConsoleKey.UpArrow)
                        {
                            try
                            {
                                map[i, j] = ".";
                                map[i - 1, j] = "+";
                            }
                            catch (Exception)
                            {

                                map[i, j] = "+";
                            }
                        }
                        else if (this.key == ConsoleKey.DownArrow)
                        {
                            try
                            {
                                map[i, j] = ".";
                                map[i + 1, j] = "+";
                            }
                            catch (Exception)
                            {

                                map[i, j] = "+";
                            }
                        }
                        else if (this.key == ConsoleKey.LeftArrow)
                        {
                            try
                            {
                                map[i, j] = ".";
                                map[i, j - 1] = "+";
                            }
                            catch (Exception)
                            {

                                map[i, j] = "+";
                            }
                        }
                        else if (this.key == ConsoleKey.RightArrow)
                        {
                            try
                            {
                                map[i, j] = ".";
                                map[i, j + 1] = "+";
                            }
                            catch (Exception)
                            {

                                map[i, j] = "+";
                            }
                        }
                        break;
                    }
                }

                if (checker)
                {
                    break;
                }
            }
        }
    }
}
