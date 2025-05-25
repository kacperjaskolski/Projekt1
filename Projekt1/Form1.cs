using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(txtInput.Text); // pobranie wartości od użytkownika
                string fromUnit = cmbFrom.SelectedItem.ToString();
                string toUnit = cmbTo.SelectedItem.ToString();

                double result = ConvertUnits(input, fromUnit, toUnit);
                lblResult.Text = "Wynik: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Błąd danych! Upewnij się, że wpisałeś liczbę i wybrałeś jednostki.");
            }
        }

        private double ConvertUnits(double value, string fromUnit, string toUnit)
        {
            // Konwersja do metrów
            double valueInMeters = value;
            switch (fromUnit)
            {
                case "metr":
                    valueInMeters = value;
                    break;
                case "kilometr":
                    valueInMeters = value * 1000;
                    break;
                case "centymetr":
                    valueInMeters = value / 100;
                    break;
                case "milimetr":
                    valueInMeters = value / 1000;
                    break;
            }

            // Konwersja z metrów do docelowej jednostki
            switch (toUnit)
            {
                case "metr":
                    return valueInMeters;
                case "kilometr":
                    return valueInMeters / 1000;
                case "centymetr":
                    return valueInMeters * 100;
                case "milimetr":
                    return valueInMeters * 1000;
            }

            return 0; // domyślna wartość, jeśli coś pójdzie nie tak
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dodaj jednostki do ComboBox
            cmbFrom.Items.AddRange(new string[] { "metr", "kilometr", "centymetr", "milimetr" });
            cmbTo.Items.AddRange(new string[] { "metr", "kilometr", "centymetr", "milimetr" });
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


