using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void TakeCourseworkIn(int mark) 
        {
            if (mark < 3) throw new RubbishCourseworkException("Sort it out you muppet!!!!!");
            // Do something
        }
    }
}
