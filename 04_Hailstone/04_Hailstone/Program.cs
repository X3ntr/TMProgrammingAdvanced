using System;

namespace _04_Hailstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            string hailstone = input.ToString();
            Hailstone(input, ref hailstone);
            Console.WriteLine(hailstone);
        }

        static void Hailstone(int n, ref string hailstone)
        {
            if(n != 1)
            {
                if(n % 2 == 0)
                {
                    //next n = n/2
                    hailstone += " " + (n / 2).ToString();
                    Hailstone(n / 2, ref hailstone);
                }
                else
                {
                    //next n = (3*n) + 1
                    hailstone += " " +  ((3 * n) + 1).ToString();
                    Hailstone((3 * n) + 1, ref hailstone);
                }
            }
        }
    }
}
