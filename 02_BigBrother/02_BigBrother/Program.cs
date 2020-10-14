using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BigBrother
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            string[] cr = Console.ReadLine().Split();

            int[] input = new int[cr.Length];

            for(int i = 0; i < cr.Length; i++)
            {
                input[i] = Convert.ToInt32(cr[i]);
            }

            foreach(int i in BigBrother(input))
            {
                Console.Write(i + " ");
            }
        }

        public static int[] BigBrother(int[] arr)
        {
            int[] result = new int[arr.Length];
            int[] copy = arr.Select(x => x).ToArray(); //deep copy
            Array.Sort(copy);

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] < copy[j])
                    {
                        result[i] = copy[j];
                        break;
                    }
                    else
                    {
                        result[i] = -1;
                    }
                }
            }
            return result;
        }
    }
}
