using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_FindTheDigit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FindDigit(n);
        }

        public static void FindDigit(long n)
        {
            //Math/reference
            //https://cs.stackexchange.com/questions/53726/nth-number-in-a-infinite-sequence-of-numbers

            //stap 1
            //n < 2^31
            //calculate to which digit group n belongs

            //count number of digits per group
            //group(i) = {9 * 10^i * (i+1)} where i=0; i++;

            //sum
            //int N = 0;

            //i represents the group length
            int i;

            //i = 0 because i0 + 1 equals first group of single digits
            for (i = 0; n > (i + 1) * 9 * (long)Math.Pow(10, i); i++)
            {
                //N += 9 * (int)Math.Pow(10, i) * (i + 1);
                //optimize performance
                n -= 9 * (long)Math.Pow(10, i) * (i + 1);
            }

            //begin of group = 10^i
            int begin = (int)Math.Pow(10, i);

            //stap 2
            //x = positive integer which counts number of numbers having m+1 digits in them
            int x = (int)Math.Floor((double)((n - 1) / (i + 1)));

            //stap3
            //e subject to r - e = 10^i + (n-N)/(i+1)
            //e subject to r - e = begin + x
            //e'th digit of X = F(n)

            String s = Convert.ToString(begin + x);
            long y = (n - 1) % (i + 1);

            Console.WriteLine(s[Convert.ToInt32(y)]);
        }
    }
}
