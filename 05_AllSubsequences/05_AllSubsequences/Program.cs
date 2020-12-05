using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AllSubsequences
{
    class Program
    {
        static List<string> buffer = new List<string>();

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Subsequences(input);

            buffer.Sort();
            

            foreach(string s in buffer.Distinct())
            {
                Console.WriteLine(s);
            }
        }

        static void Subsequences(string s, string temp = "")
        {
            if(s.Length == 0)
            {
                buffer.Add(temp);
                return;
            }

            //word length
            Subsequences(s.Substring(1), temp + s[0]);

            //substrings
            Subsequences(s.Substring(1), temp);
        }
    }
}
