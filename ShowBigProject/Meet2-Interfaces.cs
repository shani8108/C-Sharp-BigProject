using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    public interface ITax
    {
        int Maam(int price);
        int IncomeTax(int price);
    }
    public interface INewTax : ITax,ICar
    {

    }

    public interface ICar
    {

    }
    public class Meet2_Interfaces
    {
        public void Run()
        {
            ITax [] arr=new ITax[10];
            arr[0] = new Eilat();
            arr[1] = new Regular();

            foreach (ITax i in arr)
            {
                i.Maam(20);
                i.IncomeTax(20);
                
            }
            Eilat e=new Eilat();
            Test(e);
            //arr[1].GetSum(5);
        }

        public void Test(ITax tax)
        {

        }
    }

    public class Eilat : ITax
    {
        public int IncomeTax(int price)
        {
            return price * 1;        
        }

        public int Maam(int price)
        {
            return price * 1;       
        }
    }
    public class Regular : ITax
    {
        public int IncomeTax(int price)
        {
            return price * 2;
        }

        public int Maam(int price)
        {
            return price * 2;
        }

        public int GetSum(int sum)
        {
            return sum * 2;
        }
    }
}
