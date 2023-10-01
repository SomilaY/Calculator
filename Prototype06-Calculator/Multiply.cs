using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype06_Calculator
{
    internal class Multiply : iCalculator
    {
        private double Num1, Num2;

        public Multiply(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public double Calculation()
        {

            if (Num2 == 0)
            {
                throw new Exception("Cannot Multiply By 0");
            }
            else
            {
                return Num1 * Num2;
            }
        }
            public void Print()
            {
                Console.WriteLine($"Answer: {Calculation()}");
            Console.ReadLine();
            }
        }
}
