using System;
using System.Collections.Generic;

namespace IrredusibleFractions
{
    internal class IrredusibleFractionsList
    {
        #region Input
        private int lim;
        private List<int> simpleNumbers = new List<int>();

        public IrredusibleFractionsList(List<int> simpleNumbers, int lim)
        {
            this.simpleNumbers = simpleNumbers;
            this.lim = lim;
        }
        #endregion

        //...

        #region Process
        private const int START_NUMBER = 2;
        List<string> fractionsList = new List<string>();

        public void CreateFractionsList()
        {
            bool cheker = false;
            for (int i = START_NUMBER; i <= lim; i++)
            {
                for (int j = lim; j >= START_NUMBER; j--)
                {
                    if (i == j)
                    {
                        break;
                    }

                    for (int z = 0; z < simpleNumbers.Count; z++)
                    {
                        if (i % simpleNumbers[z] == 0 && j % simpleNumbers[z] == 0)
                        {
                            cheker = true;

                            break;
                        }
                    }

                    if (cheker == false)
                    {
                        fractionsList.Add($"{i}/{j}");
                    }

                    cheker = false;
                }
            }
        }

        #endregion

        //...

        #region Output
        public List<string> FractionsList
        {
            get 
            {
                return fractionsList;
            }
        }
        #endregion
    }
}
