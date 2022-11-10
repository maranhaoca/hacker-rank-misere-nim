using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'misereNim' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY s as parameter.
         */

        public static string misereNim(List<int> s)
        {
            bool allIsOne = (s.Count == s.Sum()) ? true : false;
            if (allIsOne)
            {
                return (s.Count % 2 == 0) ? "First" : "Second";
            }

            int sum = s.Aggregate((a,b) => a ^ b);

            return (sum == 0) ? "Second" : "First";
        }
    }
}