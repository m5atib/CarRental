using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BL
{
    internal class LINQExercises
    {
        public static Func<int, int> GetNextNumber = n => n + 1;

        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return from value in inValues
                   where value.Contains(pattern)
                   orderby value
                   select value;
        }

        public static IEnumerable<string> FilterAndSortV2(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                .Where(x => x.Contains(pattern))
                .OrderBy(x => x)
                .Select(x => x)
                ;
        }


    }
}
