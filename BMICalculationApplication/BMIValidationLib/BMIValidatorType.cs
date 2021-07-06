using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIValidationLib
{
    public class BMIValidatorType
    {
        public string BMIValidate(double bmiResult)
        {
            if (bmiResult < 18.5)
            {
                return "Overweight";
            }
            else if (bmiResult >= 25)
            {
                return "Healthy";
            }
            else
            {
                return "Invalid Input";
            }
        }
    }
}
