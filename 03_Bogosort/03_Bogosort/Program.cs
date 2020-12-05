using System;

namespace _03_Bogosort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Bogosort(input);
            
        }

        static void Bogosort(string[] arr)
        {
            string[] permutations = new string[Factorial(arr.Length)];
            int count = 0;
            getPermutations(arr, 0, arr.Length - 1, permutations, ref count);

            while (!isSorted(permutations))
            {
                permutations = Shuffle(permutations);
            }

            for(int i = 0; i < permutations.Length; i++)
            {
                Console.WriteLine(String.Format(i + 1 + ": " + permutations[i]));
            }
        }

        private static void Swap(ref string a, ref string b)
        {
            if (a == b) return;

            var temp = a;
            a = b;
            b = temp;
        }

        private static void getPermutations(string[] arr, int minDepth, int maxDepth, string[] permutations, ref int count)
        {
            if (minDepth == maxDepth)
            {
                string t = "";
                foreach(string s in arr)
                {
                    t += s;
                }
                permutations[count] = t;
                count++;
            }
            else
                for (int i = minDepth; i <= maxDepth; i++)
                {
                    Swap(ref arr[minDepth], ref arr[i]);
                    getPermutations(arr, minDepth + 1, maxDepth, permutations, ref count);
                    Swap(ref arr[minDepth], ref arr[i]);
                }
        }

        private static int Factorial(int a)
        {
            int product = 1;
            for(int i = a; i > 0; i--)
            {
                product *= i;
            }

            return product;
        }

        private static string[] Shuffle(string[] arr)
        {
            Random r = new Random();

            for(int i = arr.Length -1; i > 0 ; i--)
            {
                int random = r.Next(i + 1);

                string temp = arr[i];
                arr[i] = arr[random];
                arr[random] = temp;
            }
            return arr;
        }

        private static bool isSorted(string[] arr)
        {
            for(int i = 0; i < arr.Length -1; i++)
            {
                if(arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
