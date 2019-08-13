using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_task
{
    class ComplexNumber
    {
        #region Properties
        public double R { get; set; }
        public double I { get; set; }
        #endregion
        
        #region Constructors
        public ComplexNumber()
        {
            this.R = 0;
            this.I = 0;
        }

        public ComplexNumber(double a, double b)
        {
            this.R = a;
            this.I = b;
        }
        #endregion


        #region Overloading
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.R = c1.R * c2.R - c1.I * c2.I;
            complex.I = c1.R * c2.I + c1.I * c2.R;
            return complex;
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            ComplexNumber complex = new ComplexNumber();
            complex.R = ((c1.R * c2.R) + (c1.I * c2.R)) / ((c2.R * c2.R) + (c2.I * c2.I));
            complex.I = ((c2.R * c1.I) - (c1.R * c2.I)) / ((c2.R * c2.R) + (c2.I * c2.I));
            return complex;
        }
        #endregion
    }
}
