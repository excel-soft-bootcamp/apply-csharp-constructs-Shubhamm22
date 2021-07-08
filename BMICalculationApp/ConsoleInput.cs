using System;
using System.Collections.Generic;
using System.Text;

namespace BMICalculationApp
{
    class ConsoleInput
    {
        public void Display()
        {
            BMIBodyInformationLib.BodyInformationType _bodyinformation = new BMIBodyInformationLib.BodyInformationType();
            double _heightValue = _bodyinformation.ReadBodyInformation("enter your height");
            double _weightValue = _bodyinformation.ReadBodyInformation("enter your weight");


            BMICalculatorLib.BMICalculatorType _bmicalculate = new BMICalculatorLib.BMICalculatorType();
            double _bmivalue = _bmicalculate.CalculateBMIResult(_heightValue, _weightValue);

            BMIValidationLib.BMIValidatorType _bmivalidate = new BMIValidationLib.BMIValidatorType();
            string _result = _bmivalidate.BMIValidate(_bmivalue);

            BMIConsoleDisplayLib.DisplayType _display = new BMIConsoleDisplayLib.DisplayType();
            _display.BMIDisplay(_result);
        }

    }
}
