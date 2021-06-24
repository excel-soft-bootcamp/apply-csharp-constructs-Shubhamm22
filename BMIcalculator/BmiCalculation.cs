using System;
using System.Collections.Generic;
using System.Text;

namespace BMIcalculator
{
    //user defined datatype
    class BmiCalculation
    {
        #region
        //Fields
        float bmiCalculation;

        //Function
        public void DisplayBmiResult()
        {
            //instantiation
            Bodyinformation bodydata = new Bodyinformation();
            bmiCalculation = bodydata.getkilogramvalue / bodydata.getmetervalue;
            if (bmiCalculation < 18.5)
            {
                Console.WriteLine("Overweight");
            }
            else if (bmiCalculation >= 25)
            {
                Console.WriteLine("Healthy");
            }
        }
    }
    #endregion
}
