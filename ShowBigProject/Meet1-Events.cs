using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBigProject
{
    public class Meet1_Events
    {
        public delegate void TimeOut_func(int time);
        public event TimeOut_func TimeOut_handler;
        public void Run()
        {
            //boardcast event to all listeners
            if(TimeOut_handler != null)
            TimeOut_handler(1200);
        }
    }
    public class Operate
    {
        Meet1_Events meet1_events=new Meet1_Events();
        DB db = new DB();
        UI ui = new UI();


        public void Init()
        {
            //register to boardcast List

            meet1_events.TimeOut_handler += db.UpdateDBAfterTimeOut;
            meet1_events.TimeOut_handler += ui.UpdateUIAfterTimeOut;
            meet1_events.Run();
            //un register from boardcast List
            meet1_events.TimeOut_handler -= ui.UpdateUIAfterTimeOut;
            meet1_events.Run();
        }
    }
    public class DB
    {
       public void UpdateDBAfterTimeOut(int time)
        {

        }
    }

    public class UI
    {
       public void UpdateUIAfterTimeOut(int time)
        {

        }
    }
}
