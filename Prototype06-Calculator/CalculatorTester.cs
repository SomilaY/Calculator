using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype06_Calculator
{
    internal class CalculatorTester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter (1-Addition, 2-Subtract, 3-Multiply, 4-Division");
            String opt = Console.ReadLine();

            CalculatorFactory factory = new CalculatorFactory();
            iCalculator Calc = factory.GetNum(opt);
            Calc.Print();
        }
    }
}
