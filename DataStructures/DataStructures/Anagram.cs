using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Anagram
    {
        /// <summary>
        /// finding the given strings are anagram or not
        /// </summary>
        public static void CheckAnagram()
        {
            Console.WriteLine("Enter tw strings.");
            Console.WriteLine("string1 :");
            string str1 = Console.ReadLine();
            Console.WriteLine("string2 :");
            string str2 = Console.ReadLine();          
            char[] firstword = str1.ToLower().ToCharArray();
            char[] secondword = str2.ToLower().ToCharArray();
            Array.Sort(secondword);
            Array.Sort(firstword);            
            string val1 = new string(firstword);
            string val2 = new string(secondword);          
            if (val1 == val2)
            { 
                Console.WriteLine("Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the strings are not Anagrams");
            }
        }
        
    }
}
