using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FindTheX
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int[,] matrix = new int[Convert.ToInt32(dimensions[0]), Convert.ToInt32(dimensions[1])];

            for(int i = 0; i < Convert.ToInt32(dimensions[0]); i++)
            {
                string[] dimension = Console.ReadLine().Split();

                for(int j = 0; j < Convert.ToInt32(dimensions[1]); j++)
                {
                    matrix[i, j] = Convert.ToInt32(dimension[j]);
                }
            }

            Console.WriteLine(FindX(matrix));      
        }

        public static int FindX(int[,] matrix)
        {
            int x = matrix.GetLength(0);
            int y = matrix.GetLength(1);

            if (x < 3 || y < 3)
            {
                return -1;
            }
            else
            {
                int biggest = 0;

                //vertical X's
                for (int vertical = 0; vertical < x - 2; vertical++)
                {
                    //horizontal X's
                    for (int horizontal = 0; horizontal < y - 2; horizontal++)
                    {
                        int sum = 0;
                        //rows
                        for (int row = vertical; row < vertical + 3; row++)
                        {
                            //columns
                            for (int column = ((row % 2) + (vertical % 2)) % 2 + horizontal; column < horizontal + 3; column += 2)
                            {
                                sum += matrix[row, column];
                            }
                        }

                        if (sum > biggest)
                        {
                            biggest = sum;
                        }
                    }
                }

                return biggest;
            }
        }
    }
}
