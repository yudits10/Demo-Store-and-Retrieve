﻿using System;

namespace Store_and_Retrieve
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            Console.Write("Hello, ");
            Console.Write(name);
            Console.Write("! You have ");
            Console.Write(messages);
            Console.Write(" messages in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");
        }
    }
}
