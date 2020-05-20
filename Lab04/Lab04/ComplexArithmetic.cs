using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class ComplexArithmetic
    {
        String type = "";
        //ComplexAlgorithm constructor
        public ComplexArithmetic(string type)
        {
            this.type = type;
        }
        //function for addition algorithm
        public ComplexData complexAdd(ComplexData num1, ComplexData num2)
        {
            return new ComplexData(num1.re + num2.re, num2.im + num2.im);
        }
        //function for subtraction algorithm
        public ComplexData complexSub(ComplexData num1, ComplexData num2)
        {

            return new ComplexData(num1.re - num2.re, num1.im - num2.im);
        }
        //function for multiplying algorithm
        public ComplexData complexMul(ComplexData num1, ComplexData num2)
        {
            double Real = (num1.re * num2.re) - (num1.im * num2.im);
            double Imaginary = (num1.re * num2.im) + (num1.im * num2.re);


            return new ComplexData(Real, Imaginary);
        }

        //function for dividing algorithm
        public ComplexData complexDiv(ComplexData c1, ComplexData c2)
        {
            if ((c2.re == 0.0f) && (c2.im == 0.0f))
                throw new DivideByZeroException("Can't divide by zero Complex number");

            double newReal = (c1.re * c2.re + c1.im * c2.im) / (c2.re * c2.re + c2.im * c2.im);
            double newImaginary = (c2.re * c1.im - c1.re * c2.im) / (c2.re * c2.re + c2.im * c2.im);


            return new ComplexData(newReal, newImaginary);
        }



    }
}
