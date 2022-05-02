// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator1
{
    public class Calculator

    {
        // Method is used for adding two numbers
        public void Addition(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Addition of {0} + {1} = {2}", a, b, sum);
        }

        public void Substration(int a, int b)
        {
            int diff = a - b;
            Console.WriteLine("substraction of {0} - {1} = {2}",a,b, diff);
        }



        public static void Main(String[] args)
        {

            Calculator cal = new Calculator();
            cal.Addition(5, 4);
            cal.Substration(5, 4);
        }
    }
}
