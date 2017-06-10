using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimetricArray
{
    class SymmetricArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int array_length = Int32.Parse(Console.ReadLine());
            int[] array = new int[array_length];

            Console.WriteLine("Enter the value of the array:");

            for (int i = 0; i < array_length; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[array_length - i - 1])
                {
                    symmetric = false;
                }
            }

            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
    }
}
