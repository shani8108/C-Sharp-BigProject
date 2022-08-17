using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowBigProject
{
    internal class Meet3_RefVal
    {
        public void Run()
        {
            int[] arr=new int[100];
            int a = 10;
            Change(a);
            ChangeRef(ref a);
            int b;
            ChangeRefOut(ref a, out b);

            Label l=new Label();
            l.Text = "456";
            ChangeLabel(l);
        }

        public int Change(int a)
        {
            a++;
            return a*a;
        }

        public int ChangeRef(ref int a)
        {
            a++;
            return a * a;
        }

        public void ChangeRefOut(ref int a,out int b)
        {
            a++;
            //must set valur to out parameters
            b = a + a;
        }
        public Label ChangeLabel(Label l)
        {
            l.Text="123";
            return l;
        }
    }
}
