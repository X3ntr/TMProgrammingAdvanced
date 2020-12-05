using System;

namespace _03_CountingSort
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            int[] array = new int[input.Length];
            int maxValue = 0;
            int minValue = 27;

            for(int i = 0; i < input.Length; i++)
            {
                array[i] = input[i] - 96;//-96 for ascii ofset: a = 1
                if(array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if(array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            int[] count = new int[maxValue + 1];
            int[] sorted = CountingSort(array, maxValue, out count);            

            foreach (int i in sorted)
            {
                Console.Write((char)(i + 96));
            }
            Console.Write(Environment.NewLine);

            for(int i = 0; i < count.Length - minValue; i++)
            {
                Console.Write(count[i] + " ");
            }
            Console.WriteLine(Environment.NewLine);
        }


        private static int[] CountingSort(int[] array, int maxValue, out int[] countArray)
        {
            //create count array with element maxValue + 1
            int[] count = new int[maxValue + 1];

            //count each value in inputarray
            for (int i = 0; i < array.Length; i++)
            {
                int value = array[i];

                //offset value by maxValue
                count[maxValue - value]++;
            }

            //hard copy of count to countarray
            countArray = new int[count.Length];
            for(int i = 0; i < count.Length; i++)
            {
                countArray[i] = count[i];
            }

            //accumulate count value of element: n + n-1
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }

            int[] sorted = new int[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                int value = array[i];
                int position = count[maxValue - value] - 1;
                sorted[position] = value;

                count[maxValue - value]--;
            }

            return sorted;
        }
    }
}
