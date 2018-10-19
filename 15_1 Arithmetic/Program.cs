using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArithmeticProgram;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic obj = new Arithmetic();
            obj.accept();
            Console.WriteLine(obj.add());
            Console.WriteLine(obj.sub());
            Console.WriteLine(obj.mul());
            Console.WriteLine(obj.div());

        }

    }
}