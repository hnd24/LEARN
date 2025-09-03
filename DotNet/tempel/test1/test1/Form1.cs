using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //private void Exception_Forget_Enter()
        //{
        //    if (txtSoA.Text == "")
        //    {
        //        MessageBox.Show(
        //            "Bro forget to ENTER number A!!!",
        //            "Warring!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning
        //            );
        //        txtSoA.Focus();
        //        return;
        //    }
        //    if (txtSoB.Text == "")
        //    {
        //        MessageBox.Show(
        //            "Bro forget to ENTER number B!!!",
        //            "Warring!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Warning
        //            );
        //        txtSoB.Focus();
        //        return;
        //    }
        //}

        private bool Exception_DataTypeError ()
        {
            double A, B;
            bool isSuccess_A = Double.TryParse(txtSoA.Text,out A);
            bool isSuccess_B = Double.TryParse(txtSoB.Text, out B);
            if (!isSuccess_A)
            {
                MessageBox.Show(
                    "Error number A!!!",
                    "Warring!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtSoA.Focus();
                return false;
            }
            if (!isSuccess_B)
            {
                MessageBox.Show(
                    "Error number B!!!",
                    "Warring!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtSoB.Focus();
                return false;
            }
            return true;
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            if (!Exception_DataTypeError())
                return;
            //Exception_Forget_Enter();
            double result = double.Parse(txtSoA.Text) + double.Parse(txtSoB.Text);

            lblResult.Text = result + "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!Exception_DataTypeError())
                return;
            //Exception_Forget_Enter();
            double result = double.Parse(txtSoA.Text) - double.Parse(txtSoB.Text);

            lblResult.Text = result + "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            lblResult.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Exit, Bro sure ?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
