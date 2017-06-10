﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrixNND
{
    class PrintMatrixD
    {
        static void Main(string[] args)
        {
            // [ 1][12][11][10]
            // [ 2][13][16][ 9]
            // [ 3][14][15][ 8]
            // [ 4][ 5][ 6][ 7]

            int MatrixSize = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[MatrixSize, MatrixSize];
            int xCoord = 0;
            int yCoord = 0;
            int directorion = 0;
            int side = matrix.GetLength(0);
            int[,] navigator = {
                                { 1, 0 },
                                { 0, 1 },
                                { -1, 0 },
                                { 0, -1 }
                                };
            for (int iterator = 1; iterator <= side * side; iterator++)
            {
                matrix[xCoord, yCoord] = iterator;
                int nextXcoord = xCoord + navigator[directorion, 0];
                int nextYcoord = yCoord + navigator[directorion, 1];
                if (nextXcoord == side || nextXcoord == -1 || nextYcoord == side || nextYcoord == -1
                    || matrix[nextXcoord, nextYcoord] != 0)
                {
                    directorion++;
                    directorion %= 4;
                }
                xCoord += navigator[directorion, 0];
                yCoord += navigator[directorion, 1];
            }

            //print
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0}", matrix[i, j].ToString().PadRight((MatrixSize * MatrixSize).ToString().Length + 1));
                }
                if (i != matrix.GetLength(0))
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
