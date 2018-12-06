using System;

namespace Mixed_Programs
{
    class Addition
    {
        public int Dodawanie(int a)
        {
            int b = 1;
            int c;
            c = a - b;
            Console.WriteLine("Minus one");
            Console.WriteLine(c);
            System.Threading.Thread.Sleep(2000);
            return c;
        }
    }
    class Divide
    {
        public int Dzielenie(int a)
        {
            int b = 2;
            int c;
            c = a / b;
            Console.WriteLine("Divide by two");
            Console.WriteLine(c);
            System.Threading.Thread.Sleep(2000);
            c = a % b;
            Console.WriteLine("Modulo");
            Console.WriteLine(c);
            System.Threading.Thread.Sleep(2000);
            return c;
        }
    }
  /*  class Swap
    {
        public int Podmiana(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Divide by two");
            Console.WriteLine(c);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine(c);
            System.Threading.Thread.Sleep(2000);
            return c;
        }
    } */
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition A = new Addition();
            Divide D = new Divide();
            int X;
            int Y;
            Console.WriteLine("GIB ME NUMBER");
            int num1 = int.Parse(Console.ReadLine());
            X = A.Dodawanie(num1);
            X = D.Dzielenie(num1);
        }
    }
}

