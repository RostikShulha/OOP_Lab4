using System;

namespace OOP_LR4
{
    public class Pryam
    {
        protected double a;
        protected double b;

        public Pryam(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void Print()
        {
            Console.WriteLine("a = {0}  b = {1}",a , b);
        }
        virtual public double Sqr()//Віртуальний батьківський метод знаходження площі прямокутника
        {
            return a * b;
        }
        virtual public double Diag()//Віртуальний батьківський метод знаходження діагоналі прямокутника
        {
            return Math.Sqrt(b*b + a*a);
        }
    }

    public class Kvadrat : Pryam
    {
        public Kvadrat(double a) : base(a, a)
        {

        }
        public override double Sqr()//Віртуальний дочірній метод знаходження площі квадрату
        {
            return a*a;

        }
        public override double Diag()
        {
            return a * Math.Sqrt(2);
        }
        public double Radius()
        {
            return a / 2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rnd = new Random();
            double s = 0;
            double d = 0;
            for(int i = 0; i < 3; i++)
            {
                int x = rnd.Next(2, 7);
                int y = rnd.Next(2, 7);

                if (x != y)//Якщо це прямокутник
                {
                    Pryam f = new Pryam(x, y);
                    f.Print();
                    s = f.Sqr();
                    d = f.Diag();
                    Console.WriteLine("Площа прямокутника = {0}", s);
                }
                else//Якщо це квадрат
                {
                    Kvadrat f = new Kvadrat(x);
                    f.Print();
                    s = f.Sqr();
                    d = f.Diag();
                    double r = f.Radius();
                    Console.WriteLine("Площа квадрата = {0}", s);
                    Console.WriteLine("Внутрішній радіус = {0:F2}", r);
                }
                Console.WriteLine("Довжина діагоналі = {0:F2}", d);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
