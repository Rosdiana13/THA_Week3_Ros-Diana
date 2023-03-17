using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_Ros_Diana
{
    public partial class Second_Form : Form
    {
        
        public Second_Form()
        {
            InitializeComponent();
            
        }
        public string labeltext
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public void  ganti(string nama, string arti)
        {
            //label1.Text = "Hi My name is "+ nama +" and my favorite artist is" + arti;

        }
        

        //Bacground Color

        private void Magic_Click_1(object sender, EventArgs e)
        {
            if (!radioButtonBlack.Checked && !radioButtonblu.Checked && !radioButtonGreen.Checked && !radioButtonGrey.Checked && !radioButtonred.Checked
                && !radioButtonWhite.Checked && !radioButtonPink.Checked && !radioButtonYellow.Checked)
            {
                MessageBox.Show("Tolong pilih salah satu warna background dan text!!");
            }
            else if (!radioButtonBlack.Checked && !radioButtonPink.Checked && !radioButtonYellow.Checked)
            {
                MessageBox.Show("Tolong pilih salah satu warna text!!");
            }
            else if (!radioButtonblu.Checked && !radioButtonGreen.Checked && !radioButtonGrey.Checked && !radioButtonred.Checked
                && !radioButtonWhite.Checked)
            {
                MessageBox.Show("Tolong pilih salah satu warna background!!");
            }
            else
            {
                if (radioButtonred.Checked)
                {
                    Main_Form.formInstance.BackColor = Color.Red;
                }
                else if (radioButtonblu.Checked)
                {
                    Main_Form.formInstance.BackColor = Color.Blue;
                }
                else if (radioButtonGreen.Checked)
                {
                    Main_Form.formInstance.BackColor = Color.Green;
                }
                else if (radioButtonWhite.Checked)
                {
                    Main_Form.formInstance.BackColor = Color.White;
                }
                else if (radioButtonGrey.Checked)
                {
                    Main_Form.formInstance.BackColor = Color.Gray;
                }


                if (radioButtonBlack.Checked)
                {
                    Main_Form.formInstance.ForeColor = Color.Black;
                }
                else if (radioButtonPink.Checked)
                {
                    Main_Form.formInstance.ForeColor = Color.Pink;
                }
                else if (radioButtonYellow.Checked)
                {
                    Main_Form.formInstance.ForeColor = Color.Yellow;
                }
            }
        }

        
        private void checkBox_3_Click(object sender, EventArgs e)
        {
            if (checkBox_2.Checked && checkBox_3.Checked)
            {
                Magic.Enabled = true;
            }
            else
            {
                Magic.Enabled = false;
            }
        }

        private void checkBox_2_Click(object sender, EventArgs e)
        {
            if (checkBox_3.Checked && checkBox_2.Checked)
            {
                Magic.Enabled = true;
            }
            else
            {
                Magic.Enabled = false;
            }
        }
    }
}
