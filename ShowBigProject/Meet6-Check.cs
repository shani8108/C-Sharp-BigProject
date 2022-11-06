using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet6_Check
    {
        public void Run()
        {
            try
            {
                checked
                {
                    byte a = 1;
                    a = byte.MaxValue - 2;
                    a++;
                    a++;
                    a++;
                    unchecked
                    {
                        a++;
                    }
                }
            }
           catch (OverflowException ex)
            {

            }
            

            int b = int.MaxValue;
            b++;
            b++;
            b++;
            b++;
            b++;

            //after the max value it pass to max negative value.

            for (int i = 0; i < int.MaxValue; i++)
            {
                //a++;
            }
        }
    }

}
