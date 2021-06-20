using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinarySearch
    {
        /// <summary>
        /// binary search the word from list
        /// returing the x if it is present in list
        /// </summary>
        /// <param name="arr">string</param>
        /// <param name="x">index</param>
        /// <returns></returns>
        public static int Binary(String[] arr, String x)
        {
            int left = 0, right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                int res = x.CompareTo(arr[mid]);               
                if (res == 0)
                    return mid;               
                if (res > 0)
                    left = mid + 1;               
                else
                    right = mid - 1;
            }
            return -1;
        }
       
    }
}
