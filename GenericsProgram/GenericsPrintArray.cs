using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    internal class GenericPrintArray<T>
    {
        public T[] array;

        public GenericPrintArray(T[] array)
        {
            this.array = array;
        }
        public void ToPrint()
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n------------------------------------");
            Console.ReadLine();
        }
    }
}
