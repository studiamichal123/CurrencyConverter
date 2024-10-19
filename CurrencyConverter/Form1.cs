using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {

        private const decimal PLNtoUSD = 0.24m; 
        private const decimal USDtoEUR = 0.94m; 
        private const decimal USDtoCHF = 0.89m; 
        private const decimal USDtoGBP = 0.76m; 

        public Form1()
        {
            InitializeComponent();

            comboBoxCurrency.Items.AddRange(new string[] { "EUR", "CHF", "GBP" });
            comboBoxCurrency.SelectedIndex = 0; 
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                
                decimal amountPLN = decimal.Parse(textBoxAmountPLN.Text);

           
                decimal amountUSD = amountPLN * PLNtoUSD;

               
                decimal result = 0m;
                string selectedCurrency = comboBoxCurrency.SelectedItem.ToString();

                switch (selectedCurrency)
                {
                    case "EUR":
                        result = amountUSD * USDtoEUR;
                        break;
                    case "CHF":
                        result = amountUSD * USDtoCHF;
                        break;
                    case "GBP":
                        result = amountUSD * USDtoGBP;
                        break;
                }


                labelResult.Text = $"Wynik: {result:F2} {selectedCurrency}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Proszê podaæ poprawn¹ kwotê w PLN.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
