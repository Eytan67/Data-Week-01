using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Recurrsion
    {
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

    }
}
