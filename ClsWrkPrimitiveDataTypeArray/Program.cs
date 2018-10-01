using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkPrimitiveDataTypeArray
{
    class Program
    {
        static void Main(string[] args)
        {
           // Step 1: How to declare array 

            int[] array = new int[3];

            int[] arrayType1 = new int[] { 45, 67, 78 };
            int[] arrayType2 = { 45, 67, 78 };

            //  Step 2 : How to assign the value inside the memory

            array[0] = 45;
            array[1] = 67;
            array[2] = 78;

            //  Step 3 : Display array 
            Console.WriteLine("For Loop.......................");
            for (int i = 0; i < array.Length; i++)
            {
                int result = array[i];
                Console.WriteLine($"  Elements[{i}] = {result}");
            }
            Console.WriteLine("ForEach Loop.......................");

            foreach (var items in array)
            {
                Console.WriteLine($" Collection of Elements :{items}");
            }
            Console.ReadKey();
        }
    }
}
