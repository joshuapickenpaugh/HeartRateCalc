//Joshua Pickenpaugh
//June 15th, 2017
//Heartrate Calc.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRateCalc
{
    public partial class MainForm : Form
    {
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            FName = txtFName.Text;
            LName = txtLName.Text;
            YearOfBirth = Convert.ToInt32(txtAge.Text);

            HeartRates hr = new HeartRates(FName, LName, YearOfBirth);

            lblDisplayOutput.Text = hr.GetDisplayResults();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtAge.Clear();
            lblDisplayOutput.Text = "";
        }
    }
}
