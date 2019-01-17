﻿using System.Collections.Generic;

namespace GenericsDemo
{
    public static class Utils
    {
        public static IEnumerable<T> Take<T>(IEnumerable<T> source, int n)
        {
            int i = 0;

            foreach (var item in source)
            {
                yield return item;

                if (++i == n)
                {
                    yield break;
                }
            }
        }
    }
}
