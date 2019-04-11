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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            int correct_answer_total_int = (Form1.correct_answer - Form1.incorrect_answer );
            string Correct_answer_total = correct_answer_total_int.ToString();
            this.label6.Text = Correct_answer_total;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new Form1();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Activate();
            frm.Show();
            this.Hide();

        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
