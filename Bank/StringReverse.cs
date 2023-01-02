using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHelper
{
    public class StringReverse
    {
        public static string Reverse( string toReverse ) 
        {
           List<char> listOfChars = toReverse.ToList();
           listOfChars.Reverse();
           return new string (listOfChars.ToArray());
           
        }
    }
}
