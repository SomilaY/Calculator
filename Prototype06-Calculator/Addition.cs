using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype06_Calculator
{
    internal class Addition : iCalculator
    {
        private double Num1, Num2;
        public Addition(double num1, double num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }
        public double Calculation()
        { return Num1 + Num2; }

        public void Print()
        {
            Console.WriteLine($"Answer: {Calculation()}");
            Console.ReadLine();
        }
    }
}
