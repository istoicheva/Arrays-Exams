using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5};
            int length = array.Length;  // Get array length
            int[] reverse = new int[length];    // Declare and create the reversed array

            // Initiate the reverse array
            for (int index = 0; index < length; index++)
            {
                reverse[length - index - 1] = array[index];
            }

            //Print the reverse array
            for (int index = 0; index < length; index++)
            {
                Console.Write(reverse[index] + " ");
            }
        }
    }
}
