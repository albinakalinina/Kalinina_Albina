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
            string str = "Написать программу, которая определяет среднюю длину слова в строке.";
            string[] words = str.Split(new[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int averageLenght = words.Aggregate(0, (count, nextWord) => count += nextWord.Length) / words.Length;
            Console.WriteLine(averageLenght);
            Console.ReadLine();
        }
    }
}
