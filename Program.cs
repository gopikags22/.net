using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    using System;

    namespace CalculatorApp
    {
      
        class CalculatorBase
        {
           
            public CalculatorBase() => Console.WriteLine("Calculator Initialized.");

           
            public int Add(int a, int b) => a + b;
            public double Add(double a, double b) => a + b;

            public int Subtract(int a, int b) => a - b;
            public double Subtract(double a, double b) => a - b;

            public int Multiply(int a, int b) => a * b;
            public double Multiply(double a, double b) => a * b;

        
            public virtual double Divide(double a, double b)
            {
                if (b == 0)
                    throw new DivideByZeroException("Division by zero is not allowed.");
                return a / b;
            }

         
            ~CalculatorBase() => Console.WriteLine("Calculator Closed.");
        }

       
        class AdvancedCalculator : CalculatorBase
        {
          
            public override double Divide(double a, double b)
            {
                Console.WriteLine("Advanced Division Method Invoked.");
                return base.Divide(a, b);
            }

            public double Power(double a, double b) => Math.Pow(a, b);
        }

        class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    CalculatorBase calc = new AdvancedCalculator();

                    Console.WriteLine($"Add: {calc.Add(5, 3)}");
                    Console.WriteLine($"Subtract: {calc.Subtract(10, 4)}");
                    Console.WriteLine($"Multiply: {calc.Multiply(2, 6)}");
                    Console.WriteLine($"Divide: {calc.Divide(20, 4)}");

      
                    AdvancedCalculator advCalc = new AdvancedCalculator();
                    Console.WriteLine($"Power: {advCalc.Power(2, 3)}");

                    Console.WriteLine($"Divide by Zero Test: {calc.Divide(10, 0)}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected Error: {ex.Message}");
                }
            }
        }
    }
}
