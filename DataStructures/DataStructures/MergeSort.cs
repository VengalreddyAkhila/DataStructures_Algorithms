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

                  //  Merge(array,low, mid, high);
                }

             }
            static void Merge(int[] array, int low, int mid, int high)
            {
                int size1 = mid - low + 1; //defining Size of the array
                int size2 = high - mid;

                int[] firstArray = new int[size1];// create sub-array 
                int[] secondArray = new int[size2];

                for (int i = 0; i < size1; i++)
                {
                    firstArray[i] = array[low + i];
                }
                for (int j = 0; j < size2; j++)
                {
                    secondArray[j] = array[mid + 1 + j];
                }

                int x = 0, y = 0;
                int k = low;
                while (x < size1 && y < size2)
                {
                    if (firstArray[x] > secondArray[y])
                    {
                        array[k] = secondArray[y];
                        y++;
                    }
                    else
                    {
                        array[k] = firstArray[x];
                        x++;
                    }
                    k++;
                }
                while (x < size1)
                {
                    array[k] = firstArray[x];
                    x++;
                    k++;
                }
                while (y < size2)
                {
                    array[k] = secondArray[y];
                    y++;
                    k++;
                }
            }
        }
    }
}


