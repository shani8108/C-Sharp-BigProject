using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    public class Meet1_Tuple
    {
        public void Run()
        {
            int id=12;
            string name="shani";
            (int id, string name) var1;

            var1 = (123, "shani");
            var1.id = 124;
            var1.name = name;
            var newPerson=CreatePerson();
            newPerson.id = id;
        }

        public (int id, string name) CreatePerson()
        {
            (int id, string name) var1 = (123, "Nachman");
            return var1;
        }
    }
}
