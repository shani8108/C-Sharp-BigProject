using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    public class Meet1_Delegate
    {
        public delegate int  CalcFunc(int a, int b);

        public void Run()
        {
            CalcFunc f;
            f = Calc1;
            int a = f(1,1);

            f = Calc2;
            int b = f(1, 1);

            f = Calc3;
            int c = f(1, 1);

            CalcTax(200, Calc1);
            CalcTax(200, Calc2);    
            CalcTax(200, Calc3);
            
        }

        public int CalcTax(int price,CalcFunc func)
        {
            return func(price, 17);
        }
        public int Calc1(int a,int b)
        {
            return a + b;
        }
        public int Calc2(int a, int b)
        {
            return a - b;
        }
        public int Calc3(int a, int b)
        {
            return a * b;
        }
    }
}
