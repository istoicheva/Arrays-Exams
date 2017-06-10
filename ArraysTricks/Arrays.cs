using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysTricks
{
    class Arrays
    {
        static void Main(string[] args)
        {
            int n = 4;
            int number = 0;
            int[,] theArray = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > 0;)
                {
                    while (true)
                    {
                        if (theArray[i,j] == 0)
                        {
                            theArray[i, j] = number + 1;
                            number += 1;
                            break;
                        }
                        j--;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(theArray[i,j]);
                }
                Console.WriteLine();
            }
        }
   }
}
