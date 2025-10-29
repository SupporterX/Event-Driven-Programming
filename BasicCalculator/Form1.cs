using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class BasicCalculator : Form
    {
        public BasicCalculator()
        {
            InitializeComponent();

            cmbOperation.Items.AddRange(new string[] { "+", "-", "*", "/"});
            cmbOperation.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
 
            if (!float.TryParse(txtValue1.Text, out float val1) || !float.TryParse(txtValue2.Text, out float val2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }
 
            string operation = cmbOperation.SelectedItem.ToString().Trim().ToLower();
            float result = 0;

            if (operation == "+")

                result = BasicComputation.Add(val1, val2);

            else if (operation == "-")

                result = BasicComputation.Subtract(val1, val2);

            else if (operation == "*")

                result = BasicComputation.Multiply(val1, val2);

            else if (operation == "/")

                result = BasicComputation.Divide(val1, val2);

            else
            {
                MessageBox.Show("Unknown operation.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}