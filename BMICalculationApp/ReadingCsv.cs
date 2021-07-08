using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BMICalculationApp
{
    class ReadingCsv
    {
        public string name { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        static void readFile()
        {
            var lines = File.ReadAllLines(@"C:\Users\shubham.m\Downloads\download\PatientData.csv");

        }


    }
}

