using System;

namespace BMIcalculator
{ 
    //user defined datatype
    class Program
    {
        #region
        static void Main(string[] args)
        {
            //Instantiation
            Bodyinformation inputdata = new Bodyinformation();
            inputdata.ReadingBodyDetails();
            BmiCalculation  result = new BmiCalculation();
            result.DisplayBmiResult();
           
        }
    }
    #endregion
}
