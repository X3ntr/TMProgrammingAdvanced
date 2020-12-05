using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_WhatIsMissing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), Int32.Parse);

            Console.WriteLine(Missing(input, 0, 0));
        }

        public static int Missing(int[] elements, int index, int missing)
        {
            if(elements[index] - elements[index + 1] < - 1)
            {
                if(elements[index] + 1 > missing)
                {
                    missing = elements[index] + 1;
                }
            }

            if(index < elements.Length -2)
            {
                return Missing(elements, index + 1, missing);
            }
            else
            {
                return missing;
            }
        }
    }
}
