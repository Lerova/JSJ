using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Jisuan
    {
        public void Add(String num1, String num2)
        {
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
        }
        public void Jian(String num1, String num2)
        {
            Console.Write(num1 + "-" + num2 + "=");
            int i = num1.IndexOf(num2);
            num1 = num1.Remove(i,num2.Length);
            Console.WriteLine(num1);
        }
        public void Cheng(String num1, String num2)
        {
            int a, b;
            int.TryParse(num1, out a); int.TryParse(num2, out b);
            Console.WriteLine(num1 + "*" + num2 + "=" + (a * b));
        }
        public void Chu(String num1, String num2)
        {
            int a, b;
            int.TryParse(num1, out a); int.TryParse(num2, out b);
            Console.WriteLine(num1 + "/" + num2 + "=" + (a / b));
        }
    }
}
