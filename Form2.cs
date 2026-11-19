
using System;
using System.Windows.Forms;

namespace Rodilla_HomeSalesTracking
{
    public partial class Form2 : Form
    {
        public Form2(double danielle, double edward, double fatima)
        {
            InitializeComponent();

            Lbl_DanielleTotal.Text =
                "Danielle Total Sales: ₱" + danielle.ToString("N2");

            Lbl_EdwardTotal.Text =
                "Edward Total Sales: ₱" + edward.ToString("N2");

            Lbl_FatimaTotal.Text =
                "Fatima Total Sales: ₱" + fatima.ToString("N2");

            double grandTotal = danielle + edward + fatima;

            Lbl_GrandTotal.Text =
                "GRAND TOTAL: ₱" + grandTotal.ToString("N2");

            Btn_Close.Click += Btn_Close_Click;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_GrandTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
