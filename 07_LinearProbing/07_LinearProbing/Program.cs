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

            for (int i = 0; i <= size; i++)
            {
                string[] s = Console.ReadLine().Trim().Split(',');
                ht.AddItem(s[0], Convert.ToInt32(s[1]));
            }
            Console.WriteLine(ht.ToString());
        }
    }
}
