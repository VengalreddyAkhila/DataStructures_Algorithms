﻿using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to data structures problems");
            Console.WriteLine("press 1 for insertion sort:");
            Console.WriteLine("press 2 for bubblesort");
            Console.WriteLine("press 3 for permutation of string");
            Console.WriteLine("press 4 for binarysearch");
            Console.WriteLine("press 5 for mergesort");
            Console.WriteLine("enter choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                    //insertion sort
                case 1:
                    Insertionsort insertionsort = new Insertionsort();
                    insertionsort.InsertionSorting();
                    break;
                    //bubble sort
                case 2:
                    Bubblesort bubblesort = new Bubblesort();
                    bubblesort.Bubblesorting();
                    break;
                    //permutation of string
                case 3:
                    string str = "ABC";
                    int n = str.Length;
                    Console.WriteLine(" string is:");
                    PermutationofString.Permute(str, 0, n - 1);
                    Console.WriteLine("after recursive string is:");
                    PermutationofString.Recursive(str,"A");
                    break;


            }          

        }
       
    }
}
