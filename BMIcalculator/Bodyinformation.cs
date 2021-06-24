using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    //user defined datatype
    class Bodyinformation
    #region
    {
        //Fields
        private float kilogramValue;
        private float meterValue;
        /
        public float getkilogramvalue(){ return this.kilogramValue; }
        public float getmetervalue(){ return this.meterValue; }
        public void Readingbodydetails()
       
        {
            Console.WriteLine("enter the height in meters");
            kilogramValue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter the weight in Kilograms");
            meterValue = Convert.ToSingle(Console.ReadLine());
        }
       
       

        }

    }
    #endregion
    

}
