using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculatorProject {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCalc_Click(object sender, EventArgs e) {
            var billAmount = Convert.ToDecimal(txtBillAmount.Text);

            var tipPercent = 0.2m;
            txtTipPercent.Text = tipPercent.ToString("p0");
            
            var tipAmount = billAmount * tipPercent;
            txtTipAmount.Text = tipAmount.ToString("c");



        }
    }
}
