using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class GenericsArrPrint
    {
        public static void ToPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.ReadLine();
        }
    }
}