﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class ExceptionHandling
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            try
            {
                throw new Exception("Some error have occured");
                //int b = a/0;
                Console.WriteLine("Value of a is {0}", a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("Hi I am in finally block");
            }
        }
    }
}
