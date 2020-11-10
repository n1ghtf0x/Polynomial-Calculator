using System;

namespace polynomial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program calculating polynomial value!\nThis program uses Homer's algorithm.");
            Console.WriteLine("f(x) = x*a0 + (x^2)*a1 + ... + (x^n-1)*a(n - 2) + (x^n)*a(n - 1) + an");
            Console.WriteLine("First input polynomial grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            int elements = grade + 1;
            int[] factors = new int[elements];
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine("Input " + (i+1).ToString() + " factor: ");
                factors[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Now give an argument: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int h = 0; h < grade+1; h++)
            {
                double r =  Math.Pow(x, h);
                result += factors[h] * Convert.ToInt32(r);
            }

            Console.WriteLine("Your result is " + result.ToString());
            Console.ReadKey();
        }
    }
}
