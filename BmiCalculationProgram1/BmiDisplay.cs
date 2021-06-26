using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculationProgram1
{
    public class BmiDisplay
    {
        #region


        public void ConsoleDisplay(float bmiCalculation)
            {
            
          
                if (bmiCalculation < 18.5)
                {
                    Console.WriteLine("Overweight");
                }
                else if (bmiCalculation >= 25)
                {
                    Console.WriteLine("Healthy");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        

    }
    #endregion
}

