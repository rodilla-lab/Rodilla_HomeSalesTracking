
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Rodilla_HomeSalesTracking
{
    public partial class Form1 : Form
    {
        double danielleTotal = 0;
        double edwardTotal = 0;
        double fatimaTotal = 0;

        public Form1()
        {
            InitializeComponent();

            Btn_Submit.Click += Btn_Submit_Click;
            Btn_Clear.Click += Btn_Clear_Click;
            Btn_Print.Click += Btn_Print_Click;
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string salesPerson = "";

            if (salesInitial == "D")
            {
                danielleTotal += salesAmount;
                salesPerson = "Danielle";
            }
            else if (salesInitial == "E")
            {
                edwardTotal += salesAmount;
                salesPerson = "Edward";
            }
            else if (salesInitial == "F")
            {
                fatimaTotal += salesAmount;
                salesPerson = "Fatima";
            }

            double grandTotal = danielleTotal + edwardTotal + fatimaTotal;

            Lbl_Display.Text +=
                salesPerson + "'s sale recorded: ₱" +
                salesAmount.ToString("N2") + "\n" +
                "Total Sales for " + salesPerson + ": ₱" +
                getPersonTotal(salesInitial).ToString("N2") + "\n" +
                "Grand Total: ₱" + grandTotal.ToString("N2") +
                "\n\n";
        }

        private double getPersonTotal(string salesInitial)
        {
            if (salesInitial == "D")
            {
                return danielleTotal;
            }
            else if (salesInitial == "E")
            {
                return edwardTotal;
            }
            else
            {
                return fatimaTotal;
            }
        }

        private void clearEntry()
        {
            Txt_SalesInitial.Clear();
            Txt_SalesAmount.Clear();
            Lbl_Display.Text = "";

            Txt_SalesInitial.Focus();
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string salesInitial = Txt_SalesInitial.Text.Trim().ToUpper();

            double salesAmount;

            if (salesInitial != "D" &&
                salesInitial != "E" &&
                salesInitial != "F")
            {
                MessageBox.Show(
                    "Please enter D, E, or F only.",
                    "Invalid Salesperson",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Txt_SalesInitial.Focus();
                return;
            }

            if (!double.TryParse(
                Txt_SalesAmount.Text,
                NumberStyles.Currency,
                CultureInfo.CurrentCulture,
                out salesAmount))
            {
                MessageBox.Show(
                    "Please enter a valid sales amount.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Txt_SalesAmount.Focus();
                return;
            }

            if (salesAmount <= 0)
            {
                MessageBox.Show(
                    "Sales amount must be greater than zero.",
                    "Invalid Amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                Txt_SalesAmount.Focus();
                return;
            }

            getSalesPerson_Amount(salesInitial, salesAmount);

            Txt_SalesInitial.Clear();
            Txt_SalesAmount.Clear();
            Txt_SalesInitial.Focus();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            Form2 report = new Form2(
                danielleTotal,
                edwardTotal,
                fatimaTotal
            );

            report.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
