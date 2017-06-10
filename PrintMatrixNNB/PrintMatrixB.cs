using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixNNB
{
    class PrintMatrixB
    {
        static void Main(string[] args)
        {
            // [ 1][ 8][ 9][16]
            // [ 2][ 7][10][15]
            // [ 3][ 6][11][14]
            // [ 4][ 5][12][13]

            Console.Write("Enter Matrix Size: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arrayNN = new int[n, n];

            int number = 0;
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 1; col <= n; col++)
                    {
                        arrayNN[col - 1, row] = row + col + number;
                    }
                    number += 2 * n - 1;
                }
                else
                {
                    for (int j = 0; j < n; j++)
                    {
                        arrayNN[j, row] = row - j + number;
                    }
                    number -= 1;
                }
            }

            //Print
            for (int i = 0; i < arrayNN.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNN.GetLength(1); j++)
                {
                    Console.Write("{0}", arrayNN[i, j].ToString().PadRight((n * n).ToString().Length + 1));
                }
                if (i != arrayNN.GetLength(0))
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
