using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int count = 1;

            Dictionary<string, int> str = new Dictionary<string, int>();

            string text = Console.ReadLine();

            string[] splitText = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitText.Length; i++)
            {
                if (!str.ContainsKey(splitText[i].ToLower()))
                {
                    str.Add(splitText[i].ToLower(), count);
                }
                else
                {
                    str[splitText[i].ToLower()] += count;
                }
            }

            foreach (var item in str)
            {
                int even = item.Value % 2;

                if (even == 1)
                {
                    Console.Write($"{item.Key}, ");
                }
            }

        }
    }
}
