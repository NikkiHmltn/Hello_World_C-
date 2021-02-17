using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int age = 27; //defines variable as an integer, stores whole num from -2,147,483,648 to 2,147,483,648
            sbyte x = 120; //sbyte means short byte and are whole numbers from -128 to 127
            short y = 30000; // whole numbers from -32767 to 32767
            long z = 9000000000000000; //whole numbers from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            Console.WriteLine(age);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            float a = 99.99f; //decimals and a range from 1.5 x 10^-45 to 3.4 x 10^38 (f is important to confirm its a float value)
            double b = 1.5; //allows decimals and higher range than float, does not require 'f' 15 digit limit
            decimal c = 1.5456734534567634534534534567M; //allows decimals higher range than double 28 digit limit (does require the 'M')
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
