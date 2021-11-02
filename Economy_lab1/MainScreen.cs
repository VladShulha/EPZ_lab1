using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EPZ_lab1
{
    public partial class MainScreen : Form
    {
        private List<Type> Types;

        public MainScreen()
        {
            InitializeComponent();

            Types = new List<Type>();

            Types.Add(new Type("Розповсюджений", 2.4, 1.05, 2.5, 0.38));
            Types.Add(new Type("Напівнезалежний", 3, 1.12, 2.5, 0.35));
            Types.Add(new Type("Вбудований", 3.6, 1.2, 2.5, 0.32));

        }

        private void button_Click(object sender, EventArgs e)
        {
            Type currentType = getCurrentType();

            double rowsNumber = getRowsNumber();

            double PM = currentType.a * Math.Pow(rowsNumber, currentType.b);

            double TM = currentType.c * Math.Pow(PM, currentType.d);

            double SS = PM / TM;

            showAtributes(PM, TM, SS);
        }

        private Type getCurrentType()
        {
            string chosenPT = listBox_Types.Text;
            
            int i = 0;
            while(chosenPT != Types[i].Name)
            {
                i++;
            }
            return Types[i];
        }

        private double getRowsNumber()
        {
            return Convert.ToDouble(textBox_rowsNumber.Text);
        }

        private void showAtributes(double laborIntensity, double duration, double stuff)
        {
            result_laborIntensity.Text = Convert.ToString(laborIntensity);
            result_duration.Text = Convert.ToString(duration);
            result_stuff.Text = Convert.ToString(stuff);
        }
        
    }
}