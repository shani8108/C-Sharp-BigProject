using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    class aaa { }
    class bbb { }
    class ccc:aaa {
        public void Run_ccc()
        {
        }
    }
    internal class Meet6_Is_As
    {
        public void Run()
        {
            aaa a=new aaa();
            bbb b=new bbb();
            ccc c=new ccc();
            Operate(c);
        }
        public void Operate(object o)
        {
            bool test=o is aaa;
            test=o is bbb;
            test=o is ccc;
            test = o is object;
            test = o is System.IO.FileStream;
            if(o is ccc)
            {
                //run method that relevant to ccc
                //o.Run_ccc();
                //need to casting to ccc
                ccc c=o as ccc;
                c.Run_ccc();

            }
        }
    }
}
