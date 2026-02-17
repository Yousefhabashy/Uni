using System.ComponentModel;

namespace ComplexNumbers
{
    internal class Program
    {
        struct Complex 
        {
            public int real;
            public int img;
        }

        public static Complex add(Complex c1, Complex c2)
        {
            Complex result ;
            result.real = c1.real + c2.real;
            result.img = c1.img + c2.img;
            return result;
        }

        public static Complex sub(Complex c1, Complex c2)
        {
            Complex result ;
            result.real = c1.real - c2.real;
            result.img = c1.img - c2.img;
            return result;
        }

        public static Complex mul(Complex c1, Complex c2)
        {
            Complex result ;
            result.real = c1.real * c2.real - c1.img * c2.img;
            result.img = c1.real * c2.img + c1.img * c2.real;
            return result;
        }
        static void Main(string[] args)
        {
            Complex com1 = new Complex
            {
                real = 3,
                img = 2
            };

            Complex com2 = new Complex
            {
                real = 10,
                img = 30
            };

            Complex Add = add(com1, com2);
            Complex Sub = sub(com1, com2);
            Complex Mul = mul(com1, com2);

            Console.WriteLine($"Addition: {Add.real} + {Add.img}i");
            Console.WriteLine($"Subtraction: {Sub.real} + {Sub.img}i");
            Console.WriteLine($"Multiplication: {Mul.real} + {Mul.img}i");

        }
    }
}
