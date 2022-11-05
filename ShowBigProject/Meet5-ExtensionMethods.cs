using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    public class Utilities
    {
        public static int DotsCounter(string str)
        {
            return str.Split('.').Count() - 1;
        }
    }
    public  static class ExtensionStringMethods
    {
        public static int DotsCounter(this string str)
        {
            return str.Split('.').Count() - 1;
        }
        public static bool HasMobily(this Car car,int year)
        {
            if (car.GetPrice() >90 &&  year ==2022)
                return true;
            else
                return false;
        }
    }
    internal class Meet5_ExtensionMethods
    {
        public void Run()
        {
            string s = "abcddef.gfgsdfg.gfgs";
            int a = Utilities.DotsCounter(s);
            int b = s.DotsCounter();
            Car car = new Car();
            car.GetPrice();
            car.HasMobily(2022);
        }
        public int DotsCounter(string str)
        {
             return str.Split('.').Count()-1;
        }
    }
    public class Car
    {
        public int GetPrice()
        {
            return 100;
        }
    }
}
