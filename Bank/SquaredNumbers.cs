using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredNumbersNS
{
    public class SquaredNumbers
    {
        public static bool containsAllSquared(List<int> initialNumbers, List<int> squaredNumbers)
        {
            initialNumbers.Sort();
            squaredNumbers.Sort();

            List <int> squaredInitialList =  initialNumbers.Select(x => x*x).ToList();

            //return squaredInitialList.All((currentNumber, index) =>currentNumber == squaredNumbers[index]);

            bool cointainsAllSquared = true;
            for (int i = 0; i < squaredInitialList.Count; i++)
            {
                if (squaredInitialList[i] != squaredNumbers[i])
                {
                    cointainsAllSquared = false;
                }
            }
            return cointainsAllSquared;


            //return squaredInitialList.SequenceEqual(squaredNumbers);
            // List<int> mapped = new List()
            // for(int i = 0; i < initialNumbers.Count; i++) {
            //    int x = initialNumbers[i].ToString();
            //    mapped[i] = x;
            // }
            //return false;
        }


    }
}
