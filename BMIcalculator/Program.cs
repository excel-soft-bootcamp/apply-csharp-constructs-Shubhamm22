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
            inputdata.Readingbodydetails();
            bmicalculation  result = new bmicalculation();
            result.Displaybmiresult();
            



           
        }
    }
    #endregion
}
