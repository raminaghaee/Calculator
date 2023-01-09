using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string opration = "";

        double firstnum;
        double secondnum;
        public Form1()
        {
            InitializeComponent();
        }
        // drag Form
        #region MouseDown
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void NumericValue(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonX btn = (DevComponents.DotNetBar.ButtonX)sender;
            NumericValue(btn.Text);
        }
        private void NumericValue(string NumPad)
        {
            try
            {
                if (txtDisplay.Text == "0")
                    txtDisplay.Text = "";
                if (NumPad == ".")
                {
                    if (!txtDisplay.Text.Contains("."))
                    {
                        txtDisplay.Text += ".";
                    }
                }
                else
                {
                    txtDisplay.Text += NumPad;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            try
            {
                txtDisplay.Text = "0";
                string first, second;

                second = Convert.ToString(secondnum);
                first = Convert.ToString(firstnum);

                second = "";
                first = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void Operational_Function(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonX btn = (DevComponents.DotNetBar.ButtonX)sender;
            Operational_Function(btn.Text);
        }
        private void Operational_Function(string Operational)
        {
            try
            {
                firstnum = double.Parse(txtDisplay.Text);
                opration = Operational;
                txtDisplay.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnBS_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDisplay.Text.Length > 0)
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
                }
                if (txtDisplay.Text == "")
                {
                    txtDisplay.Text = "0";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
                }
                else
                {
                    txtDisplay.Text = "." + txtDisplay.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtDisplay.Text.Trim()))
                {
                    secondnum = double.Parse(txtDisplay.Text);
                    switch (opration)
                    {
                        case "+":
                            txtDisplay.Text = Convert.ToString(firstnum + secondnum);
                            break;
                        case "-":
                            txtDisplay.Text = Convert.ToString(firstnum - secondnum);
                            break;
                        case "*":
                            txtDisplay.Text = Convert.ToString(firstnum * secondnum);
                            break;
                        case "/":
                            txtDisplay.Text = Convert.ToString(firstnum / secondnum);
                            break;
                        default:
                            break;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEquals.Focus();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnC_Click(sender, e);

            //operands shortcut
            if (e.KeyCode == Keys.NumPad0)
                NumericValue("0");
            if (e.KeyCode == Keys.NumPad1)
                NumericValue("1");
            if (e.KeyCode == Keys.NumPad2)
                NumericValue("2");
            if (e.KeyCode == Keys.NumPad3)
                NumericValue("3");
            if (e.KeyCode == Keys.NumPad4)
                NumericValue("4");
            if (e.KeyCode == Keys.NumPad5)
                NumericValue("5");
            if (e.KeyCode == Keys.NumPad6)
                NumericValue("6");
            if (e.KeyCode == Keys.NumPad7)
                NumericValue("7");
            if (e.KeyCode == Keys.NumPad8)
                NumericValue("8");
            if (e.KeyCode == Keys.NumPad9)
                NumericValue("9");
            if (e.KeyCode == Keys.Decimal)
                NumericValue(".");


            //operator shortcut
            if (txtDisplay.Text != "0")
            {
                if (e.KeyCode == Keys.Add)
                    Operational_Function("+");
                if (e.KeyCode == Keys.Subtract)
                    Operational_Function("-");
                if (e.KeyCode == Keys.Multiply)
                    Operational_Function("*");
                if (e.KeyCode == Keys.Divide)
                    Operational_Function("/");
                if (e.KeyCode == Keys.Enter)
                    btnEquals_Click(sender, e);
            }
        }
    }
}
