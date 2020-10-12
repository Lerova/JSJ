using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Num num = new Num();   num.Read();
            Operator aoperator = new Operator(); aoperator.read(num.num1,num.num2);
        }
    }
}
