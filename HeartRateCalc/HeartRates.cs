using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateCalc
{
    class HeartRates
    {
        //Local private Vars:  
        private double _MaxHeartRate;
        private double _HighTargetHeartRate;
        private double _LowTargetHeartRate;

        //Vars with Getters/Setters:
        private string _FName;
        public string FName
        {
            get { return _FName; }
            set { _FName = value; }
        }

        private string _LName;
        public string LName
        {
            get { return _LName; }
            set { _LName = value; }
        }

        private int _YearOfBirth;
        public int YearOfBirth  
        {
            get { return _YearOfBirth; }
            set { _YearOfBirth = value; }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }

        private string _DisplayResults;
        public string DisplayResults
        {
            get { return _DisplayResults; }
            set { _DisplayResults = value; }
        }

        //Class Constructor:
        public HeartRates(string strFName, string strLName, int intYearOfBirth  )
        {
            FName = strFName;
            LName = strLName;
            YearOfBirth = intYearOfBirth;

            GetAge();
            MaxHeartRate();
            TargetHeartRates();
        }

        public void GetAge()
        {
            int CurrentYear;

            DateTime dt = new DateTime();
            //CurrentYear = dt.Year;
            CurrentYear = DateTime.Now.Year;

            Age = CurrentYear - YearOfBirth;
        }

        public void MaxHeartRate()
        {
            _MaxHeartRate = 220 - Age;
        }

        public void TargetHeartRates()
        {
            _HighTargetHeartRate = _MaxHeartRate * .85;
            _LowTargetHeartRate = _MaxHeartRate * .5;
        }

        public string GetDisplayResults()
        {
            DisplayResults = _FName + " " + _LName + ", age " + _Age + "." + "Maximum heart " +
                "rate is " + _MaxHeartRate + ", with a high target heart rate of " +
                _HighTargetHeartRate + " and low target heart rate of " + _LowTargetHeartRate
                + ".";

            return DisplayResults;
        }
    }
}
