using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP20230228
{
    internal class ConvertArea
    {
            // declaring the internal variables
            private double number1;
            private double result;

            // starting the properties
            public double Number1
            {
                get { return number1; }
                set { number1 = value; }
            }
            public double Result
            {
                get { return result; }
                set { result = value; }
            }

            // setting the constructors
            public ConvertArea()
            {
                this.Number1 = number1;
                this.Result = result;
            }
            public ConvertArea(double number1)
            {
                this.Number1 = 0;
            }
            // Creating the methods
            public double ToSquareInches()
            {
                result = Number1 * 0.1550;
                return result;
            }
            public double ToSquareYards()
            {
                result = Number1 * 1.960;
                return result;
            }
            public double ToAcre()
            {
                result = Number1 * 2.4711;
                return result;
            }
            public double ToSquareMiles()
            {
                result = Number1 * 0.3861;
                return result;
            }
    }
}
