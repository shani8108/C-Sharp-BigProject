using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet7_Type
    {
        FileStream fs;
        public void Run()
        {
            try
            {
                fs = System.IO.File.OpenRead("");
            }catch (Exception ex)
            {

            }
            finally
            {
                fs.Close();
            }



           // fs.Close();
        }
        public Meet7_Type()
        {
            //constructor
        }
        ~Meet7_Type()
        {
            //desctructor or finalizer
            fs.Close(); 
        }
    }
}
