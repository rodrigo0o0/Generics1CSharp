using Generics1CSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics1CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService printService = new PrintService();
            Console.Write("How many values? ");
            int values = int.Parse(Console.ReadLine());
            for (int i = 0; i < values; i++)
            {
                int aux = int.Parse(Console.ReadLine());
                printService.AddValue(aux);
            }
            printService.Print();
            Console.WriteLine();
            Console.WriteLine("First : " + printService.First());
            Console.ReadKey();
        }
    }
}
