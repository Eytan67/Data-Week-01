using System.Collections.Generic;


namespace day_2
{
    internal class Complication
    {
        //1.) O(n).
        public static int SumOddNumbers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i]%2 != 0)
                    sum += numbers[i];
            }
            return sum;
        }
        //3). O(n)
        public static bool ContainsNumber(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        //11). O(n)
        public static int FindFirstRepeating(int[] arr)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int number in arr)
            {
                if (seenNumbers.Contains(number))
                    return number;
                else
                    seenNumbers.Add(number);
            }
            return -1;
        }

        //13). O(n)
        public static float FindMissingNumber(int[] arr, int n)
        {
            float sum1 = (1+n) * ((n/2f)) ;
            int sum = 0;
            for (int i = 0 ; i < arr.Length ; ++i)
            {
                sum += arr[i];
            }
            return sum1 - sum;
        }
    }
}
