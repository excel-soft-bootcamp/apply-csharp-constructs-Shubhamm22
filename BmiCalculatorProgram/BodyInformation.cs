using System;
using System.Collections.Generic;
using System.Text;

namespace BmiCalculatorProgram
{
    class BodyInformation
    {
        
            
            private float kilogramValue;
            private float meterValue;

            public float KilogramValue
            {
                get { return this.kilogramValue; }
                set
                {
                    Console.WriteLine("enter the weight in kilograms");
                    this.kilogramValue = float.Parse(Console.ReadLine());

                }
            }
            public float MeterValue
            {
                get { return this.meterValue; }
                set
                {
                    Console.WriteLine("enter the height in meters");
                    this.meterValue = float.Parse(Console.ReadLine());
                }
            }


        }

    }

