using System;

namespace _04_ReverseInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();

            foreach (string s in array)
            {
                Console.Write(s + " ");
            }
            Console.Write(Environment.NewLine);

            ReverseInsertionSort(array);
        }

        static void ReverseInsertionSort(string[] arr)
        {
            for(int currIndex = arr.Length -1; currIndex > 0; currIndex--)
            {

                //swap currIndex -1 with arr.length -1 -i while arr.length -i > currIndex
                for (int i = 0; arr.Length - i > currIndex; i++)
                {
                    if (Convert.ToInt32(arr[currIndex - 1]) < Convert.ToInt32(arr[arr.Length - 1 - i]))
                    {

                        //swap
                        string temp = arr[currIndex - 1];
                        arr[currIndex - 1] = arr[arr.Length - 1 - i];
                        arr[arr.Length - 1 - i] = temp;
                    }
                }

                //print
                foreach (string s in arr)
                {
                    Console.Write(s + " ");
                }
                Console.Write(Environment.NewLine);           
            }
        }
    }
}
