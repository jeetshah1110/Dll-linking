using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvellousConvert
{
   public class MyConvert
    {
        int no;
        public void accept()
        {
            Console.WriteLine("enter no");
            no = Convert.ToInt32(Console.ReadLine());

            
        }
        public void ToBin()
        {
            int no1 = 0,no2=no;
            String str="",strop="";
            char[] arrop;
            while (no2!=0)
            {
                
                no1 = no2 % 2;
                str = no1.ToString();
                no2 = no2 / 2;
                strop = strop + str;
            }
             arrop = strop.ToCharArray();
             Array.Reverse(arrop);
            Console.WriteLine("binary");
            Console.WriteLine(arrop);
           
        }
        public void ToOct()
        {
            
            int no1 = 0,no2=no;
            String str ="", strop = "";
            char[] arrop;
            while (no2 != 0)
            {
                no1 = no2 % 8;
           
                str = no1.ToString();
                no2 = no2 / 8;
                strop = strop + str;
            }
            arrop = strop.ToCharArray();
            Array.Reverse(arrop);
            Console.WriteLine("octal");
            Console.WriteLine(arrop);


        }
        public void ToHex()
        {

            int no1 = 0, no2 = no;
            String str = "", strop = "";
            char[] arrop;
            while (no2 != 0)
            {
                no1 = no2 % 16;

                str = no1.ToString();
                no2 = no2 / 16;
                strop = strop + str;
            }
            arrop = strop.ToCharArray();
            Array.Reverse(arrop);
            Console.WriteLine("Hex");
            Console.WriteLine(arrop);


        }
    } 
}
