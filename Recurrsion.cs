using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Recurrsion
    {
        //1
        public static int Multiply(int a, int b)
        {
            if (b <= 0) return 0;
            return a + Multiply(a, b - 1);
        }
        //2
        public static int SumOfDigits(int num)
        {
            if(num < 10)
                return num;
            return num % 10 + SumOfDigits(num/10);
        }
        //3
        public static int Power(int a, int b)
        {
            if (b <= 0)
                return 1;
            return a * Power(a, b - 1);

        }
        //4
        public static void Reversed(int num)
        {
            if(num < 10)
                Console.Write(num);
            else
            {
                Console.Write(num % 10);
                Reversed(num/10);
            }
        }
        //5
        public static int FindSum(int[] arr, int n)
        {
            if(n < 1)
                return 0;
            return arr[n - 1] + FindSum(arr, n - 1);
        }
        //6
        public static int Divide(int a, int b)
        {
            if((a - b) < 0)
            {
                return 0;
            }
            return 1+ Divide(a - b, b);
        }
        //7
        public static bool IsPalindrome(string st, int i = 0)
        {
            if(st.Length/2 ==i)
            {
                return true;
            }
            if (st[i] != st[st.Length-i-1])
            {
                return false;
            }
            return IsPalindrome(st, ++i);
        }
        //8
        public static string DecimalToBinary(int decimalNum)
        {
            if (decimalNum == 1) return "1";
            int odd = (decimalNum % 2) == 0 ? 0 : 1;
            return DecimalToBinary(decimalNum / 2) + odd.ToString();
        }
        //9
        public static int Gcd(int a, int b)
        {
            if ((a - b) <= 0)
            {
                return a;
            }
            int d = a - b;
            return d > b ? Gcd(d, b) : Gcd(b, d);
        }
        //10
        public static void EvenNumbers(int num)
        {
            if(num < 2)
                return;

            if (num % 2 != 0)
                --num;
            EvenNumbers(num - 2);
            Console.WriteLine(num);
        }
        //11
        public static int FindMax(int[] arr, int i)
        {
            if (!(i < arr.Length))
                return int.MinValue;
            int max = FindMax(arr, i + 1);
            return arr[i] > max ? arr[i] : max;
        }
        //12
        public static int SubtracEvenOdd(int num)
        {
            if (num < 1)
                return 0;

            int x = num % 10;
            if (x % 2 != 0)
                return SubtracEvenOdd(num / 10) - x;
            else
                return SubtracEvenOdd(num / 10) + x;
        }
        //13
        public static bool Sequence(int[] arr, int i)
        {
            if(i == arr.Length-2)
                return true;
            if(arr[i] - arr[i+1] != arr[i+1] - arr[i + 2])
                return false;
            return Sequence(arr, i+1);
        }
        //14
        public static int DiffFibo(int num)
        {
            if (num < 4)
                return num;
            if (num % 2 != 0)
                return DiffFibo(num - 1) - DiffFibo(num - 3);
            return DiffFibo(num - 1) + DiffFibo(num - 2) + DiffFibo(num - 3);
        }
        //15
        public static void Permute(int[] arr)
        {

        }

    }
}
