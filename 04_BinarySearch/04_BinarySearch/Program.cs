using System;
using System.IO;

namespace _04_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("english.txt");
            string word = Console.ReadLine();

            Console.WriteLine("position " + BinarySearch(text, 0, text.Length, word));
        }

        static int BinarySearch(string[] text, int minIndex, int maxIndex, string word) 
        {
            int index = (minIndex + maxIndex) / 2;

            if (word.CompareTo(text[index]) == 0)
            {
                return index + 1;
            }
            else if (minIndex >= maxIndex)
            {
                return -1;
            }
            else if(word.CompareTo(text[index]) < 0)
            {
                return BinarySearch(text, minIndex, index - 1, word);
            }
            else
            {
                return BinarySearch(text, index + 1, maxIndex, word);
            }
        }
    }
}
