using System;

namespace Problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomDigit = new Random();

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    numbers[i] = randomDigit.Next(1, 10000);
                }
            }

            Average(numbers);

            Console.Write("Enter number: ");
            int digit = int.Parse(Console.ReadLine());
                        
            CheckNumber(numbers, digit);

            PrintSmallNum(numbers);
        }

        public static void Average(int[] num)
        {
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }

            int averageValue = sum / num.Length;

            Console.WriteLine(averageValue);
        }

        public static void CheckNumber(int[] numbers, int num)
        {
            int index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                Console.WriteLine($"Index- {index}");
                            }
            else
            {
                Console.WriteLine(index);
            }

        }

        public static void PrintSmallNum(int[] numbers)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;
     
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < first)
                {
                    second = first;
                    first = numbers[i];
                }
                else if(second > numbers[i] && numbers[i] != first)
                {
                    second = numbers[i];
                }
            }

            Console.WriteLine($"2 smaller element- {second}");
        }
    }
}
