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
        }
    }
}
