using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet3_Struct
    {
        int a;
        public void Run()
        {
            Meet3_TheRealStruct stru;
            stru.a = 123;

        }

    }
    //located in Stack
    //but if have parameter that need new in the struct this parameter is defined in Heap
    //but we cant make the New in the struct.
    struct Meet3_TheRealStruct
    {
        public int a;
        public int b;
        int c;
        public int Run()
        {
            return 12;
        }
    }
}
