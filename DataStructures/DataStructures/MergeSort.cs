using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class MergeSort
    {
         public void Sorting()
         {
            string[] arr = new string[5] { "Ram", "susmitha", "anu", "hello", "akhila" };
            Console.WriteLine("The Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }
           // Sort(arr, 0, arr.Length- 1);
            Console.WriteLine("======Sorted Array======");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
              static  void Sort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int mid = (low + high) / 2;

                    Sort(arr, low, mid);
                    Sort(arr, mid + 1, high);

                    //Merge(array,low, mid, high);
                }

             }
             static string[] Merge(string[] array, int low, int mid, int high)
            {
                int ithElement = low;
                int jthElement = mid + 1;
                int kthElement = low;
                string[] mergedArray = new string[8];

                while (ithElement <= mid && jthElement <= high)
                {
                    if ((array[ithElement].CompareTo(array[jthElement])) < 0)
                    {
                        mergedArray[kthElement] = array[ithElement];
                        ithElement++;
                    }
                    else
                    {
                        mergedArray[kthElement] = array[jthElement];
                        jthElement++;
                    }
                    kthElement++;
                }
                if (ithElement > mid)
                {
                    while (jthElement <= high)
                    {
                        mergedArray[kthElement] = array[jthElement];
                        jthElement++;
                        kthElement++;
                    }
                }
                else
                {
                    while (ithElement <= mid)
                    {
                        mergedArray[kthElement] = array[ithElement];
                        ithElement++;
                        kthElement++;
                    }
                }
                for (kthElement = low; kthElement < high; kthElement++)
                {
                    array[kthElement] = mergedArray[kthElement];
                }
                return mergedArray;
            }
         }
    }
}


