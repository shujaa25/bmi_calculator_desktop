using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double weight = double.Parse(weightBox.Text);
                double height = double.Parse(heightBox.Text);
                double heightInM = height / 3.2808;
                double bmi = weight / (heightInM * heightInM);
                bmi = Math.Round(bmi, 2);

                String resultMessage = "";

                if (bmi < 16)
                {
                    resultMessage = "Underweight (Severe thinness)";
                }
                else if (bmi <= 16.9)
                {
                    resultMessage = "Underweight (Moderate thinness)";
                }
                else if (bmi <= 18.4)
                {
                    resultMessage = "Underweight (Mild thinness)";
                }
                else if (bmi <= 24.9)
                {
                    resultMessage = "Normal range";
                }
                else if (bmi <= 29.9)
                {
                    resultMessage = "Overweight (Pre-obese)";
                }
                else if (bmi <= 34.9)
                {
                    resultMessage = "Obese (Class I)";
                }
                else if (bmi <= 39.9)
                {
                    resultMessage = "Obese (Class II)";
                }
                else if (bmi >= 40) {
                    resultMessage = "Obese (Class III)";
                }

                bmiValueLabel.Text = bmi.ToString() + " kg/m^2";
                categoryResultLabel.Text = resultMessage;
            }
            catch (Exception) {
                MessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wikiLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Body_mass_index");
        }
    }
}
