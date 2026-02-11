namespace RedefineUsingDelegate
{
/*

4)	 Redefining functions using Delegates.				 

    using System;

        interface ICalculator
        {
            int Add(int x, int y);
            int Subtract(int x, int y);
        }

        class SimpleCalculator : ICalculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Subtract(int x, int y)
            {
                return x - y;
            }
        }
        class Program
        {
            static void Main()
            {
                SimpleCalculator calc = new SimpleCalculator();
                Console.WriteLine("Addition: " + calc.Add(10, 5));
                Console.WriteLine("Subtraction: " + calc.Subtract(10, 5));
            }
        }
*/

    internal class Program
    {
        interface ICalculator
        {
            int Add(int x, int y);
            int Subtract(int x, int y);
        }
        class SimpleCalculator : ICalculator
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
            public int Subtract(int x, int y)
            {
                return x - y;
            }
        }

        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            SimpleCalculator calculator = new SimpleCalculator();

            Operation addOp = new Operation(calculator.Add);
            Operation subOp = new Operation(calculator.Subtract);

            Console.WriteLine("Addition via delegate: " + addOp(10, 5));
            Console.WriteLine("Subtraction via delegate: " + subOp(10, 5));
        }
    }
}
