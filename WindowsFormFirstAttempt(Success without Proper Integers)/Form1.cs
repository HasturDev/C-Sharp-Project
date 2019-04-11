using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormFirstAttempt
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.RadioButton1.AutoCheck = true;
           
        }
        public void Radiobuttondisable()
        {
            this.RadioButton1.AutoCheck = false;
            this.RadioButton2.AutoCheck = false;
            this.RadioButton3.AutoCheck = false;
            this.RadioButton4.AutoCheck = false;
        }        
        public void Radiobuttoncolorchange()
        {
            this.RadioButton1.BackColor = Color.Green;
            this.RadioButton4.BackColor = Color.Red;
            this.RadioButton3.BackColor = Color.Red;
            this.RadioButton2.BackColor = Color.Red;
        }

        public static int correct_answer = 0;
        public static int incorrect_answer = 0;
        internal void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttoncolorchange();
            Radiobuttondisable();

            this.label2.Visible = true;
            correct_answer++;

        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttoncolorchange();
            Radiobuttondisable();
            this.label3.Visible = true;
            incorrect_answer++;
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttoncolorchange();
            Radiobuttondisable();
            this.label3.Visible = true;
            incorrect_answer++;
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttoncolorchange();
            Radiobuttondisable();
            this.label3.Visible = true;
            incorrect_answer++;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            
            var frm = new Form2();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
            
        }
    }
}
