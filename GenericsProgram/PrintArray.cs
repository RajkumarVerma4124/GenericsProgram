using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal class PrintArray
    {
        public static void ToPrint(int[] inputArray)
        {
            foreach (int element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.ReadLine();
        }

        public static void ToPrint(double[] inputArray)
        {
            foreach (double element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.ReadLine();
        }

        public static void ToPrint(char[] inputArray)
        {
            foreach (char element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.ReadLine();
        }
    }
}