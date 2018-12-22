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
   class Swap
    {
        public int Podmiana(int a, int b)
        {
            Console.WriteLine("This is your first number: " + a);
            Console.WriteLine("This is your second number: " + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("This is your first number: " + a);
            Console.WriteLine("This is your second number: " + b);
            System.Threading.Thread.Sleep(6000);
            return 0;
        }
    }
    class Average
    {
        public int Srednia(int a, int b, int c)
        {
            int d, e;
            d = a + b + c;
            e = d / 3;
            Console.WriteLine("Suma = " + d);
            Console.WriteLine("Srednia = " + e);
            System.Threading.Thread.Sleep(6000);
            return 0;
        }
    }
    class Rectangle
    {
        public int Kwadrat(int a, int b, int c)
        {
            int[] tab = new int[3] { a, b, c };
            Console.WriteLine(tab[0]+ " " + tab[1] + " " + tab[2] + " " + tab[0] + "\n" + tab[2] + "    " +  "   " + tab[0] + "\n" + tab[0] + "   " + "    " + tab[1] + "\n" + tab[0] + " " + tab[1] + " " + tab[2] + " " + tab[0]);
            System.Threading.Thread.Sleep(10000);
            return 0;
        }
    }
    class StringModify
    {
        public string Wyluskanie(string a)
        {
            int LastLetter = a.Length;
            Console.WriteLine("Długość wyrazu wynosi: " + LastLetter + " liter");
            Random rnd = new Random();
            int RandomLetter1 = rnd.Next(1,LastLetter);
            Console.WriteLine(a.Remove(LastLetter, 1));
            System.Threading.Thread.Sleep(6000);
            return null;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition A = new Addition();
            Divide D = new Divide();
            Swap S = new Swap();
            Average Av = new Average();
            Rectangle Re = new Rectangle();
            StringModify Sm = new StringModify();
            int X;
            string Y;
            Console.WriteLine("GIB ME NUMBER");
            int num1 = int.Parse(Console.ReadLine());
            //X = A.Dodawanie(num1);
            //X = D.Dzielenie(num1);
            Console.WriteLine("GIB ME NUMBER TWO");
            int num2 = int.Parse(Console.ReadLine());
            //X = S.Podmiana(num1,num2);
            Console.WriteLine("GIB ME NUMBER THREE");
            int num3 = int.Parse(Console.ReadLine());
            //X = Av.Srednia(num1,num2,num3);
            //X = Re.Kwadrat(num1, num2, num3);
            Console.WriteLine("GIB ME SUM' STRINGGG");
            string str1 = Console.ReadLine();
            Y = Sm.Wyluskanie(str1);
        }
    }
}

