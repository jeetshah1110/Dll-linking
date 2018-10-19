using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarvellousConvert;
using MarvellousString;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConvert obj = new MyConvert();
            obj.accept();
            obj.ToBin();
            obj.ToOct();
            obj.ToHex();
            Console.WriteLine();
            xString obj1 = new xString();
            obj1.accept();
            Console.WriteLine("largest word is {0}\n", obj1.Largest());
            Console.WriteLine("palindrome {0}\n", obj1.Palindrome());
        }

    }
}