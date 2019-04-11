using System.Linq;

namespace WindowsFormFirstAttempt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.Question = new System.Windows.Forms.Label();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.Next = new System.Windows.Forms.Button();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Location = new System.Drawing.Point(157, 9);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(272, 13);
            this.Question.TabIndex = 1;
            this.Question.Text = "What is one month that golden rasberries are in season?";
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoCheck = false;
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton1.Location = new System.Drawing.Point(12, 48);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioButton1.Size = new System.Drawing.Size(58, 17);
            this.RadioButton1.TabIndex = 3;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "August";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton2.Location = new System.Drawing.Point(12, 71);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioButton2.Size = new System.Drawing.Size(55, 17);
            this.RadioButton2.TabIndex = 4;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "March";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButton3.Location = new System.Drawing.Point(12, 94);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RadioButton3.Size = new System.Drawing.Size(74, 17);
            this.RadioButton3.TabIndex = 5;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "December";
            this.RadioButton3.UseVisualStyleBackColor = true;
            this.RadioButton3.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(12, 251);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(85, 37);
            this.Next.TabIndex = 6;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Location = new System.Drawing.Point(12, 117);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(62, 17);
            this.RadioButton4.TabIndex = 7;
            this.RadioButton4.TabStop = true;
            this.RadioButton4.Text = "January";
            this.RadioButton4.UseVisualStyleBackColor = true;
            this.RadioButton4.CheckedChanged += new System.EventHandler(this.RadioButton5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Question   1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Correct! They are fresh in June, July, and August";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Incorrect. They are fresh in June, July, and August";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RadioButton4);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.RadioButton3);
            this.Controls.Add(this.RadioButton2);
            this.Controls.Add(this.RadioButton1);
            this.Controls.Add(this.Question);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton3;
        private System.Windows.Forms.Button Next;




        

        private System.Windows.Forms.RadioButton RadioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

