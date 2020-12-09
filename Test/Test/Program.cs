using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] input = Console.ReadLine().Replace(", ", ",").Split(',');
            string[] input = "Tristan Vandevelde, Sven Claessens, Elke Boonen, Collin Van der vorst, Charlie Beirnaert".Replace(", ", ",").Split(',');
            string[] surnames = new string[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                surnames[i] = input[i].Split(' ')[1];
            }

            Array.Sort(surnames, input);

            foreach(string name in input)
            {
                Console.WriteLine(name);
            }



            Array.Sort()
        }
    }
}
