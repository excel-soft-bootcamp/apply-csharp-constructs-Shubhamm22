using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorProgram
{
    //user defined datatype
    class BmiCalculation
    {
        #region
        //Fields
        float bmiCalculation;

        //Function
        public void CalculateBmi()
        {
            //instantiation
            Bodyinformation bodydata = new Bodyinformation();
            bmiCalculation = bodydata.KilogramValue / bodydata.M;
            
        }
    }
    #endregion
}
           
           
            
  