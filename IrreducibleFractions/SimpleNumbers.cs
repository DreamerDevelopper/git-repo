using System;
using System.Collections.Generic;

namespace IrredusibleFractions
{
    public class SimpleNumbers
    {
        #region Input
        private int lim;

        public SimpleNumbers(int lim)
        {
            this.lim = lim;
        }
        #endregion

        //...

        #region Process
        private int START_NUMBER = 2;
        private List<int> simpleNumbers = new List<int>();

        public void CreateSimpleNumbersList()
        {
            int cheker = 0;
            for (int i = START_NUMBER; i <= lim; i++)
            {
                for (int j = START_NUMBER; j <= lim; j++)
                {
                    if (i%j==0)
                    {
                        cheker++;
                    }
                }

                if (cheker == 1)
                {
                    simpleNumbers.Add(i);
                }

                cheker = 0;
            }
        }
        #endregion

        //...

        #region Output
        public List<int> GetSimpleNumbers 
        {            
            get 
            {
                return simpleNumbers; 
            } 
        }
        #endregion
    }
}
