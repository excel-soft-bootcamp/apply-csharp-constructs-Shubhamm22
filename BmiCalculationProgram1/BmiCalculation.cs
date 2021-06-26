using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculationProgram1
{
    //user defined datatype
    class BmiCalculation
    {
        #region
       
        //Function
        public  void  Calculate(float bmiCalculate)
            {
                //instantiation
                BodyInformation bodydata = new BodyInformation();
                bmiCalculate = bodydata.KilogramValue / bodydata.MeterValue;

            }
        
        
        #endregion
    }
}

