using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MaximumProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i]);
            }

            Console.WriteLine("Pair is " + MaximumProduct(arr));
        }

        static string MaximumProduct(int[] arr)
        {
            int x = 0;
            int y = 0;
            int product = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    int sum = (int)Math.Pow((arr[i] + arr[j]), 2);

                    if(sum > product)
                    {
                        product = sum;
                        x = arr[i];
                        y = arr[j];
                    }
                }
            }


            return String.Format("({0},{1})", x, y);
        }
    }
}
