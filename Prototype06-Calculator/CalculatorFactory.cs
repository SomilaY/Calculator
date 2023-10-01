using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype06_Calculator
{
    internal class CalculatorFactory
    {
        public iCalculator GetNum(string type)
        {
            iCalculator obj = null;
            if (type.Equals("1"))
            {
                double x, y;
                Console.WriteLine("Enter Number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Addition(x, y);
            }

            else if (type.Equals("2"))
            {
                double x, y;
                Console.WriteLine("Enter Number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Subtract(x, y);
            }
            else if (type.Equals("3"))
            {
                double x, y;
                Console.WriteLine("Enter Number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Multiply(x, y);
            }
            else if (type.Equals("4"))
            {
                double x, y;
                Console.WriteLine("Enter Number: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Number: ");
                y = Convert.ToDouble(Console.ReadLine());
                obj = new Divide(x, y);
            }
            return obj;
        }
    }
}

