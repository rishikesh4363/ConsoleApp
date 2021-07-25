using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Rishikesh 1st Console app");
            Student std = new Student();

            std.Name = "Rishikesh";
            std.StudentID = 13;
            std.Usn = "18KXS85045";

            Console.WriteLine("NAME:" + std.Name);
            Console.WriteLine("STUDENTID:" + std.StudentID);
            Console.WriteLine("REG NO:" + std.Usn);

           /* Console.WriteLine("using static method");
            Calc.Sum(5);*/
            /*
            "Using non static method,there is no need to create object,
            Whereas while using static method,we need to create object"*/
            Calc Calc = new Calc();
            Console.WriteLine("using non-static method");
            Calc.Sum(10);
        }

    }
}
