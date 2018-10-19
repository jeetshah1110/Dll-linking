using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarvellousString
{
    
    public class xString
    {
        string str;
        public void accept()
        {
            Console.WriteLine("enter string");
            str = Console.ReadLine();


        }
        public string Largest()
        {

            int max = 0;
            string strop = "";
            string[] words = Regex.Split(str, @"\s+");
            foreach (string str1 in words)
            {
                if (str1.Length > max)
                {
                    max = str1.Length;
                    strop = str1;
                }
            }
            return strop;
        }
        public bool Palindrome()
        {
            string str1 = str.ToLower();

            char[] arr = str1.ToCharArray();
            Array.Reverse(arr);
            //String str2 = arr.ToString();
            String str2 = new String(arr);
            //Console.WriteLine(str2);
            if (str1.Equals(str2))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
