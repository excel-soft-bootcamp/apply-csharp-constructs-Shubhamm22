using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BMICalculationApp
{
    class ReadingCsv
    {
      

       
        public List<string> Getlines(string path)
        {
            System.IO.StreamReader _reader = new System.IO.StreamReader(path);
            List<string> lines = new List<string>();
            while(! _reader.EndOfStream)
            {
                string pathLines = _reader.ReadLine();
                lines.Add(pathLines);
            }
            _reader.Close();
            return lines;
        }
        public CSVLib.PatientData  MapLines(string lineItem)
        {
            string[] lineItem = lineItem.Split(',');
            CSVLib.PatientData _patientData = new CSVLib.PatientData();
            _patientData.Name = lineItem[0];
            _patientData.Height = Int32.Parse(lineItem[1]);
            _patientData.Weight = Int32.Parse(lineItem[2])
                return _patientData;

        }



    }
}

