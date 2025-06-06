﻿using System;
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
        Timer zegarTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

           
            zegarTimer.Interval = 1000; 
            zegarTimer.Tick += ZegarTimer_Tick;
            zegarTimer.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double input = double.Parse(txtInput.Text); 
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

            return 0; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmbFrom.Items.AddRange(new string[] { "metr", "kilometr", "centymetr", "milimetr" });
            cmbTo.Items.AddRange(new string[] { "metr", "kilometr", "centymetr", "milimetr" });

           
            StylizujButton(btnConvert);
            StylizujButton(btnSwap); 
        }

       
        private void StylizujButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = Color.MediumSlateBlue;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btn.Height = 40;
            btn.Width = 120;
        }

      
        private void btnSwap_Click(object sender, EventArgs e)
        {
            var temp = cmbFrom.SelectedItem;
            cmbFrom.SelectedItem = cmbTo.SelectedItem;
            cmbTo.SelectedItem = temp;
        }

       
        private void ZegarTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
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

