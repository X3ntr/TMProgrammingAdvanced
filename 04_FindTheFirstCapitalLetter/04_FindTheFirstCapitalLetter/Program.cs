using System;

namespace _04_FindTheFirstCapitalLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FindCapitalLetter(input);
        }

        static void FindCapitalLetter(string s, int index = 0)
        {
            if (index < s.Length)
            {
                if (s[index].ToString() == s[index].ToString().ToUpper())
                {
                    Console.WriteLine(s[index].ToString());
                }
                else
                {
                    FindCapitalLetter(s, index + 1);
                }
            }
            else
            {
                Console.WriteLine("no capital letter found");
            }
        }
    }
}
