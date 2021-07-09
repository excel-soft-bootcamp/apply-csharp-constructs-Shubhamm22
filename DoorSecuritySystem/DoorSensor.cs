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
            Statuschanged.Invoke(this.status);
        }
        public void Close() 
        {
            status = "close";
            Statuschanged.Invoke(this.status);
        }
    }
}
