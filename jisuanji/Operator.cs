using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Operator:Jisuan
    {
        public int a = 0;
        public void read(String num1,String num2)
        {
            Console.WriteLine("-1、加法");
            Console.WriteLine("-2、减法");
            Console.WriteLine("-3、乘法");
            Console.WriteLine("-4、除法");
            Console.Write("请选择你要进行的操作：");
            String paymode = Console.ReadLine();
            int.TryParse(paymode, out a);
            if (a == 1) Add(num1,num2);
            if (a == 2) Jian(num1, num2);
            if (a == 3) Cheng(num1, num2);
            if (a == 4) Chu(num1, num2);
        }
        //public void Add(int num1,int num2)
        //{
        //    Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
        //}
        //public void Jian(int num1, int num2)
        //{
        //    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
        //}
        //public void Cheng(int num1, int num2)
        //{
        //    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
        //}
        //public void Chu(int num1, int num2)
        //{
        //    Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
        //}
    }
}
