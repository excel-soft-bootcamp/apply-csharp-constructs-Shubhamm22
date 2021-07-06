using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApplication
{
    class Program
    {
        static void Main(string[] args)
        {
           BMIbodyInformationLib.BMIBodyInformationType   _bodyinformation = new BMIbodyInformationLib.BMIBodyInformationType();
            double heigh = _bodyinformation.ReadBodyInformation("enter your height");
            double weight = _bodyinformation.ReadBodyInformation("enter your weight");

            BMICalculatorLib.BMICalculatorType _bmicalculate = new BMICalculatorLib.BMICalculatorType();
            double _bmivalue = _bmicalculate.CalculateBMIResult(heigh, weight);

            BMIValidationLib.BMIValidatorType bmivalidate = new BMIValidationLib.BMIValidatorType();
            string result = bmivalidate.BMIValidate(_bmivalue);

            BMIConsoleDisplayLib.ConsoleDisplayType display = new BMIConsoleDisplayLib.ConsoleDisplayType();
            display.BMIDisplay(result);
        }
    }
}
