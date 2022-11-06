using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet8_Generics
    {
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("aaaa");

            List<int> list2 = new List<int>();  
            list2.Add(1);
            Point p = new Point(100, 300);
            string s = Func<Point, String>(p, "aaaaaaa");

            Sample<Point> sample = new Sample<Point>();
            sample.SetItem(p);
        }
       
        public class Sample<T> where T:new()//interface(IEnumerable<Z>)//Base-class//unmanaged//struct//class
        {
            public void SetItem(T item)
            {

            }
        }
        public class PrintManager<T>
        {

        }
        public string Func<T,Z>(T o,Z y)
        {
            return o.ToString()+" "+y.ToString();
        }
    }
}
