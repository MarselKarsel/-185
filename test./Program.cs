using System;

namespace ConsoleApp3calculator
{


       public class Program

    {

        public double function(double a, double b, char oper)
        {
            double total;
            if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Совсем дурак?");
                return total;

            }

            else if (oper == '+')
            {
                total = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + total);
                return total;

            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + total);
                return total;
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + total);
                return total;
            }

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + total);
                return total;

            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
                return 1;

            }
            return 0;

        }
        public double Main(string[] args)
        {
            double a; double b; double total; char oper;
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            b = Convert.ToDouble(Console.ReadLine());

            function(a, b, oper);

          
        }
    }
}
