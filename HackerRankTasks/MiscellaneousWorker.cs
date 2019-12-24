using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTasks
{
    public class MiscellaneousWorker
    {
        #region FlippingBits
        //https://www.hackerrank.com/challenges/flipping-bits/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=miscellaneous
        public bool[] ConvertDecimalToBinary(long decimalNumber)
        {
            var result = new bool[32];
            var i = 0;
            while (decimalNumber / 2 > 0)
            {
                result[i] = Convert.ToBoolean(decimalNumber % 2);
                decimalNumber /= 2;
                i++;
            }
            result[i] = Convert.ToBoolean(decimalNumber % 2);
            Array.Reverse(result);
            return result;
        }

        public long ConvertBinaryToDecimal(bool[] binaryNumber)
        {
            var result = 0L;
            var baseDegree = 1L;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                result += Convert.ToInt64(binaryNumber[i]) * baseDegree;
                baseDegree *= 2;
            }
            return result;
        }

        public long FlipBits(long number)
        {
            bool[] binaryNumber = ConvertDecimalToBinary(number);
            for (var i = 0; i < binaryNumber.Length; i++)
            {
                binaryNumber[i] = !binaryNumber[i];
            }
            long result = ConvertBinaryToDecimal(binaryNumber);
            return result;
        }
        #endregion
    }
}
