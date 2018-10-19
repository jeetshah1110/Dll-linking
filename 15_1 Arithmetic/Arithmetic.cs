using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticProgram
{
   public class Arithmetic
    {
        int no1, no2;
        public void accept()
        {
            Console.WriteLine("enter no1");
            no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no2");
            no2 = Convert.ToInt32(Console.ReadLine());
        }
        public int add()
        {
            return no1 + no2;
        }
        public int sub()
        {
            return no1 - no2;
        }
        public int mul()
        {
            return no1 * no2;
        }
        public int div()
        {
            return no1 / no2;
        }
    } 
}
