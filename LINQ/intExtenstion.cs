using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal static class intExtenstion
    {
        //Extension method
        public static int Reverse(this int number)
        {
            int ReverseNumber = 0, LastDigit;

            while (number > 0)
            {
                LastDigit = number % 10;
                number = number / 10;
                ReverseNumber = ReverseNumber * 10 + LastDigit;
            }
            return ReverseNumber;

        }
    }
}
