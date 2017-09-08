using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //ArrayTest.RotateArray(-1, 3);
                ArrayTest.RotateArray(7, 3);
                Console.WriteLine();
                //ArrayTest.RotateArray(20, 6);

                // Missed the example had a method signature to start with
                // Refactored original method RotateArray
                int[] nums = ArrayTest.BuildArray(7);
                ArrayTest.Rotate(nums, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}