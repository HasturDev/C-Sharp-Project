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
   
    
    public partial class Form2 : Form
    {
        public int correct_answer2;
        
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Question 2";
            this.radioButton1.AutoCheck = true;
            
        }
        public void Radiobuttondisable()
        {
            this.radioButton1.AutoCheck = false;
            this.radioButton2.AutoCheck = false;
            this.radioButton3.AutoCheck = false;
            this.radioButton4.AutoCheck = false;
        }
        public void Radiobuttoncolorchange()
        {
            this.radioButton1.BackColor = Color.Red;
            this.radioButton4.BackColor = Color.Red;
            this.radioButton3.BackColor = Color.Red;
            this.radioButton2.BackColor = Color.Green;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttondisable();
            Radiobuttoncolorchange();
            this.label3.Visible = true;
            Form1.incorrect_answer++;
        }
        
        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            Radiobuttondisable();
            Radiobuttoncolorchange();
            this.label4.Visible = true;
            Form1.correct_answer++;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttondisable();
            Radiobuttoncolorchange();
            this.label3.Visible = true;
            Form1.incorrect_answer++;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Radiobuttondisable();
            Radiobuttoncolorchange();
            this.label3.Visible = true;
            Form1.incorrect_answer++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form3();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }
    }
}
