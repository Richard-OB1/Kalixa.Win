using System;
using System.Collections.Generic;

namespace Kalixa.Win
{
    /// <summary>
    /// Tech test to find common elements in two lists using NOTHING in the Linq namespace
    /// which would usually include IEnumerable and the Intersect extension method
    /// Old school!
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            ListComparer listComparer = new ListComparer();

            Console.WriteLine("Kalixa Technical Test");

            Console.WriteLine($"Characters in common in List One and List Two: {CharListToString(listComparer.GetCommonList())}");

            Console.WriteLine("Press enter to close...");

            Console.ReadLine();
        }

        public static string CharListToString(List<char> charList)
        {
            return string.Concat(charList.ToArray());
        }

    }
}