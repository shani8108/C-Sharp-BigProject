using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    internal class Meet5_GarbageCollector
    {
        public Stack<Car> cars1 = new Stack<Car>();
        public event Action EventHandler;
        public void Run()
        {
            Car car = new Car();
            Stack<Car> cars = new Stack<Car>();
            for (int i = 0; i < 10; i++)
            {
                // in the end of for the all object without ref delete.
                Car car1 = new Car();
                //in the end of func the stack will delete
                cars.Push(car1);
                // this delete in the end of running the app
                cars1.Push(car1);
            }
            //memory allocation
            //free memory

            //disadvantages GC
            //defregmentation
            //freeze threads

            //relase huge memory
            //run the GC free process
            GC.Collect();
            //MEMORY LEAKS

            for (int i = 0; i < 1000; i++)
            {
                Screen screen = new Screen();
                EventHandler += screen.Run;
            }
        //because event handler that ref to object 
        //so the GC not delete this object
        }
        public class CarPool
        {
            private Stack<Car> cars = new Stack<Car>();
            private CarPool()
            {
                for (int i = 0; i < 100; i++)
                {
                    cars.Push(new Car());
                }

            }
            public Car Allocate()
            {
                return null;
            }

            public void Free(Car car)
            {

            }

        }
        public class Screen
        {
            public void Run()
            {

            }
        }
    }
}
