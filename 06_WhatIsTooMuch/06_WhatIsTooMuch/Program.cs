using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_WhatIsTooMuch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Distinct(input, new List<string>(), 0);
        }

        public static void Distinct(string[] elements, List<string> buffer, int index)
        {
            if(!buffer.Contains(elements[index])) {
                buffer.Add(elements[index]);
                Console.Write(elements[index] + " ");
            }

            if(index < elements.Length -1)
            {
                Distinct(elements, buffer, index + 1);
            }
            else
            {
                return;
            }
        }
    }
}
