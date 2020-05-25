using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        const int length = 5;

        static void Main(string[] args)
        {
            Random randomDigit = new Random();

            int[,] digit = new int[5, 5];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    digit[i, j] = randomDigit.Next(1, 10000);
                }
            }


            MinElement(digit);
        }

        public static void MinElement(int[,] number)
        {
            Dictionary<int, int> smallest = new Dictionary<int, int>();

            int minElement = int.MaxValue;
            int element = int.MaxValue;
            int index = 0;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int num = number[j, i];

                    if (minElement > num)
                    {
                        minElement = num;

                        if (minElement < element)
                        {
                            element = minElement;
                            index = j;
                        }
                    }
                }

                smallest.Add(i, index);
                
                Console.WriteLine($"Colum {i} smallest element {minElement}");

                minElement = int.MaxValue;
            }

            AddNumber(index, smallest);

            
            Console.WriteLine($"Row on small element- {index}");
        }

        public static void AddNumber(int index, Dictionary<int, int> nums)
        {
            int[] element = new int[5];

            for (int i = 0; i < element.Length; i++)
            {
                int key = nums.ElementAt(i).Key;
                int value = nums.ElementAt(i).Value;
                element[i] = key - value * index;
            }
        }
    }
}
