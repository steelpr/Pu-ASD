using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            string[] product = Console.ReadLine().Split();
            
            while(product[0] != "end")
            {
                if (!products.ContainsKey(product[0]))
                {
                    products.Add(product[0], int.Parse(product[1]));
                }
                else
                {
                    products[product[0]] += int.Parse(product[1]);
                }
                product = Console.ReadLine().Split();
            }

            Sort(products);
        }

        public static void Sort(Dictionary<string, int> products)
        {
            string product = string.Empty;
            int productQ = 0;

            while (products.Count > 0)
            {
                foreach (var item in products)
                {
                    if (item.Value > productQ)
                    {
                        product = item.Key;
                        productQ = item.Value;
                    }
                }
                Console.WriteLine(product + " " + productQ);



                productQ = 0;
                products.Remove(product);
            }
        }
    }
}
