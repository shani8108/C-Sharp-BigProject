using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowBigProject
{
    internal class Meet3_Nullable
    {
        public void Run()
        {
            //System.ValueType vs Object
            int a;
            Label l = null;
            if (l == null)
            {
                l = new Label();
            }

            //a = null;//error because not nullable

            int? b;
            b = null;
            //3 option to check if the parameter is defined or not
            if (b == null)
            {
                b = 0;
            }
            if (b is null)
            {

            }
            if (b.HasValue)
            {

            }

            //a = b;//we dont lnow if be is defined
            //so put ?? if null do something and if not null do anything....

            a  = b ?? 2;

            Label l1 = null;

            l1 ??=new Label();
            if (l1 == null)
            {
                l1 = new Label();
            }
        }
    }
}
