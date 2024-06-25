using System;

namespace RunningSumOf1DArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1480.
            //int[] nums = new int[] { 1, 2, 3, 4 };
            //int[] nums = new int[] { 1, 1, 1, 1, 1 };
            //int[] nums = new int[] { 3, 1, 2, 10, 1 };
            Console.Write("What is the length of the array: ");
            int numsLength = int.Parse(Console.ReadLine());
            int[] nums = new int[numsLength];
            for(int i = 0; i < numsLength; i++)
            {
                Console.Write($"Enter array[{i + 1}] value: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            nums = Solution.RunningSum(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if(i != 0)
                {
                    Console.Write(",");
                }
                Console.Write(nums[i]);
            }

            Console.WriteLine("\nDone processing.");
            Console.ReadLine();
        }
    }
}
