using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowBigProject
{
    internal class Meet3_StackHeap
    {
        public void Run()
        {
            //set in the HEAP because it have NEW definition
            //but the set of l is in Stack
            Label label = new Label();
            //each int is 4 byte
            //arr is set in Stack and catch 4 byte
            //int[100] *4=400 byte is set on Heap
            //because this is in New ...
            int[] arr = new int[100];
        }

    }
}
