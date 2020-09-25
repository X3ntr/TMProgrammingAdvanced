using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_BinarySearch
{
    public class Program
    {
        public static int BinarySearch(string word, string[] text, out int guesses)
        {
            //reset counter
            guesses = 0;

            //binary search
            int min = 0;
            int max = text.Length - 1;

            while (min <= max)
            {
                guesses++;
                int index = (min + max) / 2;

                if(text[index] == word)
                {
                    return index +1;
                }
                else
                {
                    int charindex = 0;
                    while(charindex < word.Length && charindex < text[index].Length)
                    {
                        if(word[charindex] > text[index][charindex])
                        {
                            //split into upper half
                            min = index + 1;
                            break;
                        }
                        else if (word[charindex] < text[index][charindex])
                        {
                            //split into lower half
                            max = index - 1;
                            break;
                        }
                        else
                        {
                            charindex++;
                        }
                        if(min == max) { max--; }
                    }
                }
            }

            //return -1 if not found
            return -1;
        }

        public static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("english.txt");
            string input = Console.ReadLine();

            int guesses;
            int position = BinarySearch(input, text, out guesses);

            Console.WriteLine(String.Format("position {0} in {1} guesses", position, guesses));
        }
    }
}
