using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartRateCalc
{
    class HeartRates
    {
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

        //Local private Vars:  
        private double _MaxHeartRate = 0;
        private double _TargetHeartRate = 0;

        //Class Constructor:
        public HeartRates(string strFName, string strLName, int intYearOfBirth  )
        {
            FName = strFName;
            LName = strLName;
            YearOfBirth = intYearOfBirth;
        }

        public void GetAge()
        {
            int CurrentYear;

            DateTime dt = new DateTime();
            CurrentYear = dt.Year;
        }

        public void TargetHeartRate()
        {
             
        }

        public void MaxHeartRate()
        {
             
        }
    }
}
