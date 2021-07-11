using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSecuritySystem
{
    public delegate void Statushandler(string status);
    class DoorSensor
    {
        string status = "idle";
        public event Statushandler Statuschanged;
        public void Open()
        {
            status= "open";
            //Statuschanged.Invoke(this.status);
            this.Notify();
        }
        public void Close() 
        {
            status = "close";
            //Statuschanged.Invoke(this.status);
            this.Notify();
        }
        void Notify()
        {
            string message = $"{this.status} and Time : {System.DateTime.Now.ToString()}";
            Statuschanged.Invoke(message);
        }
    }
}
