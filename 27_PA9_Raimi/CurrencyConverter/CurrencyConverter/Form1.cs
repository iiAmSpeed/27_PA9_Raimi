using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {

        public float convertedAmount;
        public float amount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            try
            {

                amount = Convert.ToSingle(txt_Amount.Text);

                if (rb_US.Checked)
                {
                    convertedAmount = 0.74f * amount;
                }

                else if (rb_Yen.Checked)
                {
                    convertedAmount = 81.97f * amount;
                }

                else if (rb_Ringgit.Checked)
                {
                    convertedAmount = 3.01f * amount;
                }
                else if(rb_Yen.Checked == false || rb_US.Checked == false || rb_Ringgit.Checked == false)
                {
                    MessageBox.Show("Please check a radio button.");
                }

                txt_Converted.Text = convertedAmount.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter a valid amount after clicking on Convert");
            }
        }

        private void txt_Amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Converted_TextChanged(object sender, EventArgs e)
        {

        }

        private void rb_US_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Amount.Text = "";
            txt_Converted.Text = "";
            rb_Yen.Checked = false;
            rb_US.Checked = false;
            rb_Ringgit.Checked = false;
        }

        private void rb_Ringgit_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
