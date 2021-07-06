using System;

namespace BmiCalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        { 



            BodyInformation _bodyinformation = new BodyInformation();
            float heightValue = _bodyinformation.MeterValue;
            float weightValue = _bodyinformation.KilogramValue;

            BmiCalculateLib.CalculateType.Calculate(heightValue, weightValue);
           BmiValidateLib.ValidateType.Validate()
                 
           

        }
    }
}
