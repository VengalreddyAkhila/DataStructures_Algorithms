using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PermutationofString
    {
        /// <summary>
        /// permutation of a string using itterative method
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="s">starting index</param>
        /// <param name="e">ending index</param>
        public static void Permute(String str, int start, int end)
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start + 1, end);                    
                    str = Swap(str, start, i);
                }
            }
        }      
        /// <summary>
        /// swapping the string at position
        /// </summary>
        /// <param name="a">string value</param>
        /// <param name="i">position 1</param>
        /// <param name="j">position 2</param>
        /// <returns>return swapped string</returns>
        public static String Swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
        /// <summary>
        /// permutation of a string using recursive method
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="a">string value</param>
        public static void Recursive(string str,string a)
        {
            if (str.Length == 0)
            {
                Console.WriteLine(a);
                return;
            }
            for (int i=0;i < str.Length; i++)
            {
                char c = str[i];
                string start = str.Substring(0, i);
                string end = str.Substring(i + 1);
                string r = start + end;
                Recursive(r, a + c);
            }
        }
    }
}
