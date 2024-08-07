﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        private static int i = 0;
        private Singleton() { i++; Console.WriteLine($"SingletonClass constructor called count {i}"); } //adding private will prevent the invoke of instantiation
        private static Singleton? instance;
        public static Singleton GetInstance()
        {
            if (instance == null) //lazy instantiation
                instance = new Singleton();
            return instance;
        }
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
