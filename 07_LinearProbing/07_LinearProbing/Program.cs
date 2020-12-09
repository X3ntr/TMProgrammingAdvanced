using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LinearProbing
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            HashTable ht = new HashTable(size);

            bool x = false;
            while(!x)
            {
                string[] s = Console.ReadLine().Replace(", ", ",").Split(',');

                if(s.Length == 1 && s[0] == "x")
                {
                    x = true;
                    break;
                }

                if (s.Length == 2)
                {
                    ht.AddItem(s[0], Convert.ToDouble(s[1]));
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(ht.ToString());
        }
    }
}
