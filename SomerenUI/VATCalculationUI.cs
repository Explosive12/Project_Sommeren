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

        private void QuarterSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillForm();
        }

        private void CalcVattextBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
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


        private void FillForm()
        {
            try
            {
                if (QuarterSelectionComboBox.SelectedItem == null)
                    return;
                int startMonth = GetStartMonth();
                int year = GetYear();
                DateTime startDate = new DateTime(year, 1, 1).AddMonths(startMonth);
                DateTime endDate = new DateTime(year, 1, 1).AddMonths(startMonth + 3).AddDays(-1);
                CalcVat(startDate, endDate);
                DisplayDateRange(startDate, endDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hola some error");
            }
        }

        private void DisplayDateRange(DateTime startDate, DateTime endDate)
        {
            CalcVatTextBoxFrom.Text = startDate.ToString("dd-MM-yyyy");
            CalcVatTextboxTo.Text = endDate.ToString("dd-MM-yyyy");
        }

        private void CalcVat(DateTime startDate, DateTime endDate)
        {
            decimal totalVat6 = 0;
            decimal totalVat21 = 0;

            foreach (VatOrder order in vatOrders)
            {
                if (order.Date < startDate || order.Date > endDate)
                    continue;
                if (!order.IsAlcohol)
                    totalVat6 += order.Price - (order.Price / (1 + (decimal)0.06));
                else
                    totalVat21 += order.Price - (order.Price / (1 + (decimal)0.21));
            }
            DisplayVat(RoundCurrency(totalVat6), RoundCurrency(totalVat21));
        }
        private decimal RoundCurrency(decimal value)
        {
            return Math.Round(value, 2);
        }

        private void DisplayVat(decimal totalVat6, decimal totalVat21)
        {
            textBox6Vat.Text = totalVat6.ToString("C");
            textBox21Vat.Text = totalVat21.ToString("C");
            textBoxTotalVat.Text = (totalVat21 + totalVat6).ToString("C");
        }

        private int GetStartMonth()
        {
            string selectedQuarter = QuarterSelectionComboBox.SelectedItem.ToString();
            int startMonth = QuarterToMonth(selectedQuarter);
            return startMonth;
        }

        private int GetYear()
        {
            return int.Parse(CalcVatTextBoxYear.Text);
        }

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
