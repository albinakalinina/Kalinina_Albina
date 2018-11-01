using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {

            var peopleList = GenerateList(20);
            var p = peopleList;
            while (p != p.NextPeople)
            {
                if (peopleList == p.NextPeople)
                {
                    peopleList = p.NextPeople.NextPeople;
                }
                p = p.NextPeople = p.NextPeople.NextPeople;
    
                PrintList(peopleList);
            }
        }

        private static void PrintList(People peopleList)
        {
            var p = peopleList;
            do
            {
                System.Console.WriteLine(p.SequenceNumber);
                System.Console.WriteLine(" ");
                p = p.NextPeople;
            } while (p != peopleList);
            System.Console.WriteLine();
        }
        private static People GenerateList(int n)
        {
            var currentPeople = new People(n);
            var lastPeople = currentPeople;
            for (int i = n - 2; i > 0; i--)
            {
                currentPeople = new People(i) { NextPeople = currentPeople };
            }
            lastPeople.NextPeople = currentPeople;
            return currentPeople;
        }
    }
}
    