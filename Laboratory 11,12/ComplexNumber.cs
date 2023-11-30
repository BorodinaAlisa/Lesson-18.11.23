using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_11_12
{
    public class ComplexNumber
    {
        private double real;
        private double imaginary;
        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.real + c2.real;
            double imaginary = c1.imaginary + c2.imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.real - c2.real;
            double imaginary = c1.imaginary - c2.imaginary;
            return new ComplexNumber(real, imaginary);
        }
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.real * c2.real - c1.imaginary * c2.imaginary;
            double imaginary = c1.real * c2.imaginary + c1.imaginary * c2.real;
            return new ComplexNumber(real, imaginary);
        }
        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.real == c2.real && c1.imaginary == c2.imaginary;
        }
        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }
        public override string ToString()
        {
            return $"{real} + {imaginary}i";
        }
    }
}
