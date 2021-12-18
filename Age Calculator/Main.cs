using System;
using System.Windows.Forms;

namespace Age_Calculator
{
    public partial class Main : Form
    {
        private int birthdate;
        private int hours;

        public Main()
        {
            InitializeComponent();

            birthdayPicker.Format = DateTimePickerFormat.Custom;
            birthdayPicker.CustomFormat = "MM/dd/yyyy hh";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StoreValues();
            Calculation();
        }

        private void StoreValues()
        {
            birthdate = birthdayPicker.Value.Date.Year;
            hours = birthdayPicker.Value.Date.Hour;
        }

        private void Calculation()
        {
            int age = (DateTime.Now.Year - birthdate >= 0) ? DateTime.Now.Year - birthdate : 0;
            int daysOld = age * 365;
            int hoursOld = (age > 0) ? DateTime.Now.Minute - hours : 0;

            MessageBox.Show($"{age} years, {daysOld} days and {hoursOld} hours old.");
        }
    }
}
