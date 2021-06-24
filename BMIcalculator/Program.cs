using System;

namespace BMIcalculator
{ 
    class Program
    {
        #region
        static void Main(string[] args)
        {
            float BMI;
            bmi _instance = new bmi();
            float kgvalue = _instance.Getkg();
            Console.WriteLine("enter the height in meters");
            kgvalue = Convert.ToSingle(Console.ReadLine());
            

            float mvalue = _instance.Getm();
            Console.WriteLine("enter the weight in Kilograms");
            mvalue = Convert.ToSingle(Console.ReadLine());

            BMI = kgvalue/mvalue;
            if (BMI < 18.5)
            {
                Console.WriteLine("OverWeight");

            }
            else if (BMI >= 25)
            {
                Console.WriteLine("Healthy");

            }
            else
            {
                Console.WriteLine("invalid Entry");
            }



            #endregion
        }
    }
}
