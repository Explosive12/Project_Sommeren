using SomerenModel;
using SomerenService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class VATCalculationUI : Form
    {
        public List<VatOrder> vatOrders { get; }
        public VATCalculationUI()
        {
            InitializeComponent();
            VatOrderService service = new();
            vatOrders = service.GetAllVatOrders();
        }

        // Fill Form when one of the 2 changeable things get changed
        private void QuarterSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillForm();
        }

        private void CalcVattextBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
            // when it no number, show the error
                if (!int.TryParse(CalcVatTextBoxYear.Text, out int year))
                {
                    throw new ArgumentOutOfRangeException($"Invalid year:'{CalcVatTextBoxYear.Text}'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hola some error");
            }
            FillForm();
        }


// Here things for the Form gets calculated and filled in
        private void FillForm()
        {
            try
            {
                if (QuarterSelectionComboBox.SelectedItem == null)
                    return;
                int startMonth = GetStartMonth();
                int year = GetYear();
                DateTime startDate = new DateTime(year, 1, 1).AddMonths(startMonth);
                // quarter is 12 / 4 = 3 so 3 months and -1 because it ends a day before
                DateTime endDate = new DateTime(year, 1, 1).AddMonths(startMonth + 3).AddDays(-1);
                CalcVat(startDate, endDate);
                DisplayDateRange(startDate, endDate);
            }
            //throw Exception when something goes wrong
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hola some error");
            }
        }

// Displays the begin and end date in the labels
        private void DisplayDateRange(DateTime startDate, DateTime endDate)
        {
            CalcVatTextBoxFrom.Text = startDate.ToString("dd-MM-yyyy");
            CalcVatTextboxTo.Text = endDate.ToString("dd-MM-yyyy");
        }

// Calculate VAT of drinks
        private void CalcVat(DateTime startDate, DateTime endDate)
        {
            decimal totalVat6 = 0;
            decimal totalVat21 = 0;

            foreach (VatOrder order in vatOrders)
            {
            // make it so its only from the selected quarter
                if (order.Date < startDate || order.Date > endDate)
                    continue;
                    // check if the order has acohol in it (use bit to make it true or false in DB)
                if (!order.IsAlcohol)
                    totalVat6 += order.Price - (order.Price / (1 + (decimal)0.06));
                else
                    totalVat21 += order.Price - (order.Price / (1 + (decimal)0.21));
            }
            DisplayVat(RoundCurrency(totalVat6), RoundCurrency(totalVat21));
        }
        
        //Round the decimals up to 2 after dot / comma
        private decimal RoundCurrency(decimal value)
        {
            return Math.Round(value, 2);
        }

// Display the Calculations of VAT
        private void DisplayVat(decimal totalVat6, decimal totalVat21)
        {
            textBox6Vat.Text = totalVat6.ToString("C");
            textBox21Vat.Text = totalVat21.ToString("C");
            textBoxTotalVat.Text = (totalVat21 + totalVat6).ToString("C");
        }

// get the starting month of the quarter
        private int GetStartMonth()
        {
            string selectedQuarter = QuarterSelectionComboBox.SelectedItem.ToString();
            int startMonth = QuarterToMonth(selectedQuarter);
            return startMonth;
        }

// Get Year in int form
        private int GetYear()
        {
            return int.Parse(CalcVatTextBoxYear.Text);
        }

// Check which option is selected in the Combobox and add amount of months to the quarter so it starts at the correct position
        private int QuarterToMonth(string selectedQuarter)
        {
            switch (selectedQuarter)
            {
                case "Q1":
                    return 0;
                case "Q2":
                    return 3;
                case "Q3":
                    return 6;
                case "Q4":
                    return 9;
                default:
                    throw new ArgumentOutOfRangeException("Invalid Quarter");

            }
        }


    }
}
