using System.Collections.Generic;
using System.Linq;

namespace GenericsDemo
{
    class Program
    {
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        static void Main()
        {
            var list1 = new List<int> { 1, 2, 3, 4, 5 };
            var list2 = new List<int> { 2, 4, 6, 8, 10 };
            var set = new HashSet<int> { 3, 6, 9, 12, 15 };
            var array1 = new[]{ 4, 8, 12, 16, 20 };

            int numOdd =
                    list1.Count(x => IsOdd(x)) +
                    list2.Count(x => IsOdd(x)) +
                    set.Count(x => IsOdd(x)) +
                    array1.Count(x => IsOdd(x)); 


       // too many for-loop below, use LINQ
            
            //foreach (var value in list1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}

            //foreach (var value in list2)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}

            //foreach (var value in set)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}
            //foreach (var value in array1)
            //{
            //    if (IsOdd(value))
            //    {
            //        numOdd++;
            //    }
            //}
        }
    }
}
