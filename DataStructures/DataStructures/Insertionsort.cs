using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Insertionsort
    {    
        /// <summary>
        /// Insertion sort method 
        /// </summary>
        public void InsertionSorting()
        {
            string[] arr = new string[5] { "Ram", "susmitha","a", "hello", "akhila" };          
            Console.WriteLine("The Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]);
            }           
            for (int j = 1; j < arr.Length; j++)
            {
                string temp = arr[j];
                int i = j - 1;
                while((i >= 0) && (arr[i].CompareTo(temp) > 0))
                {
                    arr[i + 1] = arr[i];
                    i--;
                }
                arr[i + 1] = temp;
            }
            // sorted  list is displayed
            Console.WriteLine("------------------");
            Console.WriteLine("sorted list :");
            for (int i=0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }                 
       
        }
    }

}

