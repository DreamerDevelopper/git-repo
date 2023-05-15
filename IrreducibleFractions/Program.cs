using System;
using System.Collections.Generic;

namespace IrredusibleFractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I can create a list of irredusible fractions ");
            Console.WriteLine("Enter the number I have to work up to");
            int lim = int.Parse(Console.ReadLine());

            SimpleNumbers simpleNumbersModule = new SimpleNumbers(lim);
            simpleNumbersModule.CreateSimpleNumbersList();
            List<int> simpleNumbers = simpleNumbersModule.GetSimpleNumbers;

            IrredusibleFractionsList fractionsList = new IrredusibleFractionsList(simpleNumbers, lim);
            fractionsList.CreateFractionsList();
            List<string> fractions = fractionsList.FractionsList;

            foreach (var item in fractions)
            {
                Console.Write(item + " ");
            }

            Console.Read();
        }
    }
}