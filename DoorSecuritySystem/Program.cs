using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {

           SecuritySystem _observer = new SecuritySystem();
            Statushandler _notify = new Statushandler(_observer.Sms);

            DoorSensor _doorsensor = new DoorSensor();
            _doorsensor.Statuschanged += _notify;
           _doorsensor.Open();
        }

    }
}
