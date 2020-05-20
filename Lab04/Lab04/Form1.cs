using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        //create all data objects
        private double real_one = 0.0;
        private double real_two = 0.0;
        private double imaginary_one = 0.0;
        private double imaginary_two = 0.0;
        ComplexData first_num;
        ComplexData second_num;
        ComplexData complex_answer;
        public Form1()
        {
            InitializeComponent();
        }

        //add button event 
        private void add_button_Click(object sender, EventArgs e)
        {

            if (((Double.TryParse(real_1.Text, out real_one) && Double.TryParse(imaginary_1.Text, out imaginary_one))) && (Double.TryParse(real_2.Text, out real_two) && Double.TryParse(imaginary_2.Text, out imaginary_two)))
            {
                first_num = new ComplexData(real_one, imaginary_one);
                second_num = new ComplexData(real_two, imaginary_two);
                complex_answer = first_num + second_num;

                answer.Text = Convert.ToString(complex_answer.re) + " + " + Convert.ToString(complex_answer.im) + " i";


            }
            else
                answer.Text = "Check your input and try again";


        }

        //sub button event
        private void sub_button_Click(object sender, EventArgs e)
        {
            if (((Double.TryParse(real_1.Text, out real_one) && Double.TryParse(imaginary_1.Text, out imaginary_one))) && (Double.TryParse(real_2.Text, out real_two) && Double.TryParse(imaginary_2.Text, out imaginary_two)))
            {
                first_num = new ComplexData(real_one, imaginary_one);
                second_num = new ComplexData(real_two, imaginary_two);
                complex_answer = first_num - second_num;

                answer.Text = Convert.ToString(complex_answer.re) + " + " + Convert.ToString(complex_answer.im) + " i";


            }
            else
                answer.Text = "Check your input and try again";

        }

        //multiply button event
        private void mul_button_Click(object sender, EventArgs e)
        {
            if (((Double.TryParse(real_1.Text, out real_one) && Double.TryParse(imaginary_1.Text, out imaginary_one))) && (Double.TryParse(real_2.Text, out real_two) && Double.TryParse(imaginary_2.Text, out imaginary_two)))
            {
                first_num = new ComplexData(real_one, imaginary_one);
                second_num = new ComplexData(real_two, imaginary_two);
                complex_answer = first_num * second_num;

                answer.Text = Convert.ToString(complex_answer.re) + " + " + Convert.ToString(complex_answer.im) + " i";
            }
            else
                answer.Text = "Check your input and try again";


        }

        //divide button event
        private void div_button_Click(object sender, EventArgs e)
        {
            if (((Double.TryParse(real_1.Text, out real_one) && Double.TryParse(imaginary_1.Text, out imaginary_one))) && (Double.TryParse(real_2.Text, out real_two) && Double.TryParse(imaginary_2.Text, out imaginary_two)))
            {
                first_num = new ComplexData(real_one, imaginary_one);
                second_num = new ComplexData(real_two, imaginary_two);
                complex_answer = first_num / second_num;

                answer.Text = Convert.ToString(complex_answer.re) + " + " + Convert.ToString(complex_answer.im) + " i";
            }

            else
                answer.Text = "Check your input and try again";
        }
    }
}
