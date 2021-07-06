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
            BmiCalculateLib.CalculateType _calculateinstance = new BmiCalculateLib.CalculateType();
            float bmiValue = _calculateinstance.Calculate(heightValue, weightValue);
            BmiValidateLib.ValidateType _validateinstance = new BmiValidateLib.ValidateType();
            string result = _validateinstance.Validate(bmiValue);
            BmiDisplay _bmidisplay = new BmiDisplay();
            _bmidisplay.ConsoleDisplay(result);









        }
    }
}
