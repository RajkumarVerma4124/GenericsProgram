using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the array print program using generic class and method ");
            Console.ReadLine();

            while(true)
            {
                int x = 10, y = 20, z = 30;
                int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
                double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
                char[] charArray = { 'A', 'B', 'C', 'D', 'E' };
                Console.WriteLine("1: Print Using Normal Method \n2: Print Using Generic Method \n3: Print Using Generic Class \n4: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Printing Array Normal Methods : ");
                        PrintArray.ToPrint(intArray);
                        PrintArray.ToPrint(doubleArray);
                        PrintArray.ToPrint(charArray);
                        break;
                    case 2:
                        Console.WriteLine("Printing Array Generic Methods : ");
                        GenericsArrPrint.ToPrint<int>(intArray);
                        GenericsArrPrint.ToPrint<double>(doubleArray);
                        GenericsArrPrint.ToPrint<char>(charArray);
                        break;
                    case 3:
                        Console.WriteLine("Printing Array Generic Class : ");
                        new GenericPrintArray<int>(intArray).ToPrint();
                        new GenericPrintArray<double>(doubleArray).ToPrint();
                        new GenericPrintArray<char>(charArray).ToPrint();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter A Right Choice");
                        break;
                }
            }
        }
    }
}
