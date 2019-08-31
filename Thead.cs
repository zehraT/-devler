using System;
using System.Collections.Generic;
using System.Threading;

namespace Zar_Atma
{
    class Program
    {

        public static Random random = new Random();
        public static Thread thread1 = new Thread(Num1);
        public static Thread thread2 = new Thread(Num2);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            thread1.Start();
            thread2.Start();
            Console.ReadLine();
        }


        private static void Num1()
        {
            for (int i = 0; i <= 100; i++)
            {
                int number = random.Next(6);
                Console.WriteLine("Zar 1: " + number);
            }
        }
        private static void Num2()
        {
            for (int i = 0; i <= 100; i++)
            {
                int number = random.Next(6);
                Console.WriteLine("Zar 2: " + number);
            }
        }

    }
}
