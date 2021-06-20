using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to data structures problems");
            Console.WriteLine("press 1 for insertion sort:");
            Console.WriteLine("press 2 for bubblesort");
            Console.WriteLine("press 3 for mergesort");
            Console.WriteLine("press 2 for binarysearch");
            Console.WriteLine("press 3 for permutation");
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
                    //merge sort
                case 3:
                    break;


            }          

        }
            
    }
}
