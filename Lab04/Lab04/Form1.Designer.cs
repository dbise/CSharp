﻿namespace Lab04
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
        private void InitializeComponent()
        {
            this.real_1 = new System.Windows.Forms.TextBox();
            this.imaginary_1 = new System.Windows.Forms.TextBox();
            this.real_2 = new System.Windows.Forms.TextBox();
            this.imaginary_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.sub_button = new System.Windows.Forms.Button();
            this.mul_button = new System.Windows.Forms.Button();
            this.div_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // real_1
            // 
            this.real_1.Location = new System.Drawing.Point(232, 108);
            this.real_1.Name = "real_1";
            this.real_1.Size = new System.Drawing.Size(62, 26);
            this.real_1.TabIndex = 0;
            // 
            // imaginary_1
            // 
            this.imaginary_1.Location = new System.Drawing.Point(330, 108);
            this.imaginary_1.Name = "imaginary_1";
            this.imaginary_1.Size = new System.Drawing.Size(47, 26);
            this.imaginary_1.TabIndex = 1;
            // 
            // real_2
            // 
            this.real_2.Location = new System.Drawing.Point(232, 162);
            this.real_2.Name = "real_2";
            this.real_2.Size = new System.Drawing.Size(62, 26);
            this.real_2.TabIndex = 2;
            // 
            // imaginary_2
            // 
            this.imaginary_2.Location = new System.Drawing.Point(330, 162);
            this.imaginary_2.Name = "imaginary_2";
            this.imaginary_2.Size = new System.Drawing.Size(47, 26);
            this.imaginary_2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Complex Number 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Complex Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "+";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(42, 267);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(122, 48);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // sub_button
            // 
            this.sub_button.Location = new System.Drawing.Point(191, 267);
            this.sub_button.Name = "sub_button";
            this.sub_button.Size = new System.Drawing.Size(132, 48);
            this.sub_button.TabIndex = 8;
            this.sub_button.Text = "Subtract";
            this.sub_button.UseVisualStyleBackColor = true;
            this.sub_button.Click += new System.EventHandler(this.sub_button_Click);
            // 
            // mul_button
            // 
            this.mul_button.Location = new System.Drawing.Point(42, 355);
            this.mul_button.Name = "mul_button";
            this.mul_button.Size = new System.Drawing.Size(122, 48);
            this.mul_button.TabIndex = 9;
            this.mul_button.Text = "Multiply";
            this.mul_button.UseVisualStyleBackColor = true;
            this.mul_button.Click += new System.EventHandler(this.mul_button_Click);
            // 
            // div_button
            // 
            this.div_button.Location = new System.Drawing.Point(191, 355);
            this.div_button.Name = "div_button";
            this.div_button.Size = new System.Drawing.Size(132, 48);
            this.div_button.TabIndex = 10;
            this.div_button.Text = "Divide";
            this.div_button.UseVisualStyleBackColor = true;
            this.div_button.Click += new System.EventHandler(this.div_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(522, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Answer";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(426, 84);
            this.answer.Multiline = true;
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(297, 132);
            this.answer.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(300, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "i";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "i";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Real ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(302, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Imaginary";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.div_button);
            this.Controls.Add(this.mul_button);
            this.Controls.Add(this.sub_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imaginary_2);
            this.Controls.Add(this.real_2);
            this.Controls.Add(this.imaginary_1);
            this.Controls.Add(this.real_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox real_1;
        private System.Windows.Forms.TextBox imaginary_1;
        private System.Windows.Forms.TextBox real_2;
        private System.Windows.Forms.TextBox imaginary_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button sub_button;
        private System.Windows.Forms.Button mul_button;
        private System.Windows.Forms.Button div_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

