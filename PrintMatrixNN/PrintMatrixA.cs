using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixNN
{
    class PrintMatrixA
    {
        static void Main(string[] args)
        {
            // [ 1][ 5][ 9][13]
            // [ 2][ 6][10][14]
            // [ 3][ 7][11][15]
            // [ 4][ 8][12][16]

            Console.Write("Enter Matrix Size: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] arrayNN = new int[n, n];

            int number = 0;
            for (int row = 0; row < n; row++)
            {

                for (int col = 0; col < n; col++)
                {
                    arrayNN[col, row] = row + col + number + 1;
                }
                number += n - 1;
            }

            // Print
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