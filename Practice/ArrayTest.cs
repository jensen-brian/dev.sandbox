using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class ArrayTest
    {
        /// <summary>
        /// Rotate an array of n elements to the right by k steps.
        ///
        /// For example, with n = 7 and k = 3, the array[1, 2, 3, 4, 5, 6, 7] is rotated to[5, 6, 7, 1, 2, 3, 4].
        /// </summary>
        /// <param name="nElements"></param>
        /// <param name="kSteps"></param>
        public static void RotateArray(int nElements, int kSteps)
        {
            Console.WriteLine("RotateArray: n = {0} and k = {1}", nElements, kSteps);
            if ((nElements > 0) && (kSteps > 0) && (kSteps < nElements))
            {
                // 1. Build the array and output what it looks like
                int[] array = BuildArray(nElements);

                // 2. Rotate the array
                Rotate(array, kSteps);
            }
            else
            {
                Console.WriteLine("n and k must be greater than zero AND k must be less than n");
            }
        }

        public static int[] BuildArray(int nElements)
        {
            if (nElements < 1) { throw new ArgumentException("Must be greater than zero.", "nElements"); }

            int[] array = new int[nElements];
            for (int i = 0; i < nElements; i++)
            {
                array[i] = (i + 1);
            }
            printArray(array);
            return array;
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums == null) { throw new ArgumentNullException("nums"); }
            if (k >= nums.Length) { throw new ArgumentException(String.Format("k must be less than nums array length. {0} < {1}", k, nums.Length), "k"); }


            int nElements = nums.Length;
            int[] rotatedArray = new int[nElements];
            for (int i = 0; i < nums.Length; i++)
            {
                int indexer = (i + k);
                int move = nums[i];
                if (indexer < nElements)
                {
                    // insert at as long as the new index is not bigger than the array
                    rotatedArray[indexer] = move;
                }
                else
                {
                    // modulo gives you the remainder to use as the new index to insert at
                    rotatedArray[indexer % nElements] = move;
                }
            }
            printArray(rotatedArray);
        }

        private static void printArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                // look ahead and see if there is one more value to write = we need a comma
                if ((i+1) < array.Length)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}