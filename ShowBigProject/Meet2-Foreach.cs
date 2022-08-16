using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet2_Foreach
    {
        public void Run()
        {
            int[] arr = new int[100];
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            LinkedList<int> list = new LinkedList<int>();
            var a=list.ToArray();
            for (int i = 0; i < a.Length; i++)
            {
                a[i]++;
            }
        }

        public void RunMyItems()
        {
            Items items = new Items();

            string allStr = "";
            foreach (var i in items)
            {
                allStr += i.ToString();
            }
        }
    }

    public class Items : IEnumerable, IEnumerator
    {
        public string[] list = { "ball", "Shirt", "CD" };
        int idx = -1;
        public object Current => list[idx];

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            //condition
            //jump to next position
            if (idx < list.Length-1)
            {
                idx++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            idx = -1;
        }
    }
}
