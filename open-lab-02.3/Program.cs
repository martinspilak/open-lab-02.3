﻿using System;

namespace open_lab_02._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a % b;
            Console.WriteLine(c);
        }
    }
}
