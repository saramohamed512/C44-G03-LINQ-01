using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSession1
{
    internal static class IntExtention
    {

        public static int Reverse(this int Number) {
            int ReversedNumber = 0;
            int Reminder;
            while (Number != 0) {
                Reminder = Number % 10;
                ReversedNumber= ReversedNumber*10+Reminder;
                Number = Number/10;

            }
            return ReversedNumber;
        }
    }
}
