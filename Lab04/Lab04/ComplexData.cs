using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class ComplexData
    {
        
        public double re, im;
        public double Re { get; set; }
        public double Im { get; set; }

        //ComplexData constructor
        public ComplexData(double _re, double _im)
        {
            re = _re;
            im = _im;
        }
        //override addition operator
        public static ComplexData operator +(ComplexData num1, ComplexData num2)
        {
            ComplexArithmetic myAdd = new ComplexArithmetic("+");
            
            return myAdd.complexAdd(num1, num2);

        }

        //override subtraction operator
        public static ComplexData operator -(ComplexData num1, ComplexData num2)
        {


            ComplexArithmetic mySub = new ComplexArithmetic("-");
            return mySub.complexSub(num1, num2);
        }

        //override multiplication operator
        public static ComplexData operator *(ComplexData num1, ComplexData num2)
        {

            ComplexArithmetic myMul = new ComplexArithmetic("*");
            return myMul.complexMul(num1, num2);
        }

        //override division operator
        public static ComplexData operator /(ComplexData num1, ComplexData num2)
        {
            ComplexArithmetic myDiv = new ComplexArithmetic("/");
            return myDiv.complexDiv(num1, num2);
        }


    }
}
