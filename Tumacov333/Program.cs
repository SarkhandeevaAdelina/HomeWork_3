using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumacov333
{
    internal class Program
    {
        static void Main(string[] args)
        {
            up41();
            Console.ReadKey();
        }
        public static void up41()
        {
            Console.WriteLine("Задача:Ввести число от 1 до 365 и получить на выходе месяц и число");
            Console.WriteLine("Введите число от 1 до 365");
            int n = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, 1, 1);
            Console.WriteLine($"{n} соответствует: {date.AddDays(n - 1).ToString("dd MMMM")}");
        }
        public static void up42()
        {

            Console.WriteLine("Задача:Ввести число от 1 до 365 и получить на выходе месяц и число");
            Console.WriteLine("Введите число от 1 до 365");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n > 365)
            {
                DateTime date = new DateTime(1, 1, 1);
                Console.WriteLine($"{n} соответствует: {date.AddDays(n - 1).ToString("dd MMMM")}");
            }
            else
            {
                Console.WriteLine("Числа были введены не верно");

            }
        }
        public static void dz41()
        {
            Console.WriteLine("Задача:Ввести число от 1 до 365 и получить на выходе месяц и число");
            Console.Write("Введите число от 1 до 365: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n < 365)
            {
                DateTime date = new DateTime(1, 1, 1);
                Console.WriteLine($"{n} соответствует: {date.AddDays(n - 1).ToString("dd MMMM")}");
            }
            else
            {
                Console.WriteLine("Числа были введены не верно");

            }
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine($"{year} год - високосный");
            }
            else
            {
                Console.WriteLine($"{year} год - не високосный");
            }

        }
        public static void dz411()
        {
            Console.WriteLine("Задача:Ввести число от 1 до 365 и получить на выходе месяц и число");
            Console.Write("Введите число от 1 до 365: ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n < 365)
            {
                DateTime date = new DateTime(1, 1, 1);
                Console.WriteLine($"{n} соответствует: {date.AddDays(n - 1).ToString("dd MMMM")}");
            }
            else
            {
                Console.WriteLine("Числа были введены не верно");

            }
            Console.Write("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            if ((year % 100 != 0) && (year % 4 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            if ((year % 100 == 0) && (year % 400 == 0))
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Не високосный");
            }

        }
    }
}
