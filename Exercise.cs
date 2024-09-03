using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Exercise
    {
        public static int CalculateOddSum(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                //sum += number % 2 == 0 ? number : 0;
                if(number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        //public static int[] FindMaximumTwo(int[] numbers)
        //{
        //    int max = numbers[0]+numbers[1];
        //    for(int i = 1; i < numbers.Length -1; ++i)
        //    {
        //        if (numbers[i] + )
        //    }
        //}

        public static bool ContainsNumber(int[] nums, int num)
        {
            for( int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] == num)
                {
                    return true;
                }
            }
            return false;
        }

        public static int SumOfAllTriplets(int[] nums)
        {
            int[] max = new int[3];
            for (int i = 0; i < nums.Length; ++i)
            {
                if(nums[i] > max[2])
                {
                    if (nums[i] > max[1])
                    {
                        if (nums[i] > max[0])
                        {
                            max[2] = max[1];
                            max[1] = max[0];
                            max[0] = nums[i];
                        }
                        else
                        {
                            max[2] = max[1];
                            max[1] = nums[i]; 
                        }
                    }
                    else
                    {
                        max[2] = nums[i];
                    }
                }
            }
            return max[0] + max[1] + max[2];
        }


    }
}
