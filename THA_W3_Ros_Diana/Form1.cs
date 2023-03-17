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
    public partial class Main_Form : Form
    {
        public static Main_Form formInstance;
        public TextBox TextBox;
        Second_Form secondForm = new Second_Form();
        int tes = 0;
        public Main_Form()
        {
            InitializeComponent();
            formInstance = this;

        }
        //Main Form
        private void checkBox_true_CheckedChanged(object sender, EventArgs e)
        {
            if (tes == 1 && checkBox_true.Checked)
            {
                button_Submit.Enabled = true;
            }
            else
            {
                button_Submit.Enabled = false;
            }
        }

        private void buttonnextform_Click(object sender, EventArgs e)
        {
            tes = 1;
            secondForm.Show();
            if (tes == 1 && checkBox_true.Checked)
            {
                button_Submit.Enabled = true;
            }
            else
            {
                button_Submit.Enabled = false;
            }
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            //secondForm.ganti(textBox_Name.Text, textBox_Favorite_Artist.Text);
            if (string.IsNullOrEmpty(textBox_Favorite_Artist.Text) || string.IsNullOrEmpty(textBox_Name.Text))
            {
                MessageBox.Show("Please input the textbox!!");
            }
            else 
            {
                secondForm.labeltext = "Hi My name is " + textBox_Name.Text + " and my favorite artist is " + textBox_Favorite_Artist.Text;
            }
        }
    }
}
