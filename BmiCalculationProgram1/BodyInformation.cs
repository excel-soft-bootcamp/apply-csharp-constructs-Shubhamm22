using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculationProgram1
{
    //user defined datatype
    class BodyInformation
    {
        #region
            //Fields
            private float kilogramValue;
        private float meterValue;

        public float KilogramValue
        {
            get { return this.kilogramValue; }
        }
        public float MeterValue
        {
            get { return this.MeterValue; }
        }
        public void ReadingBodyDetails()

        {
            Console.WriteLine("enter the height in meters");
            kilogramValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the weight in Kilograms");
            meterValue = Convert.ToSingle(Console.ReadLine());
        }
    }
    #endregion
}





