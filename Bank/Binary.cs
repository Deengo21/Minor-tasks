using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNS
{
    public interface BinaryConverter
    {
        string ConvertToBinary(int decimalNumber);
    }

    public abstract class SuperFastBinaryConverter
    {
        public abstract string ConvertToBinary(int decimalNumber);
    }

    public class BinaryGap
    {
        BinaryConverter binaryConverter;

        public BinaryGap(BinaryConverter binaryConverter)
        {
            this.binaryConverter = binaryConverter;
        }

        public int Count(int decimalNumber)
        {
            string binary = this.binaryConverter.ConvertToBinary(decimalNumber);

            List<char> binaryList = binary.ToList();
            int zeroCount = 0;
            int maxZeros = 0;
            for (int i = 0; i < binaryList.Count; i++)
            {
                if (binaryList[i] == '1')
                {
                    zeroCount = 0;  
                }
                if (binaryList[i] == '0')
                {
                    zeroCount++;
                    if (zeroCount > maxZeros)
                    {
                        maxZeros = zeroCount;
                    }

                   
                }

            }
            return maxZeros;

        }

        private string ToBinary(int decimalNumber)
        {
            string binaryRepresentation = "";  
            // while number > 0
            // calculate number % 2 -> add as the first digit
            // number = number / 2 

                return binaryRepresentation;
        }
    }
}
