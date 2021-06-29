using System;
using System.Collections.Generic;
using System.Text;

namespace TataCarProgram
{
    class Car 
    {
        Iengine  _engine;

        public  Car(Iengine engine)
        {

            this._engine = engine;
        }

        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }
    }
}
