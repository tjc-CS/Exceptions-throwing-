using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                TakeCourseworkIn(2);
                // What is done if coursework is good

            }catch(RubbishCourseworkException e)
            {
                Console.WriteLine(e.WhatDoIDo());
            }

           

        }

        static void TakeCourseworkIn(int mark) 
        {
            if (mark < 3) throw new RubbishCourseworkException("Sort it out!!!!");
            // Do something
        }
    }
}
