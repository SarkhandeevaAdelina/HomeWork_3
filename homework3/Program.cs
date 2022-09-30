using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1();
            Console.ReadKey();
        }
        public static void Ex1()
        {
            Console.WriteLine("Задача:Вася просовывает голову в форточку");
            Console.Write("Введите размеры форточки:a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите размеры форточки:b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы Васи:d=");
            int d = int.Parse(Console.ReadLine());
            if ((d + 2 <= a) && (d + 2 <= b))
            {
                Console.WriteLine("Вася сможет пролезть");
            }
            else
            {
                Console.WriteLine("Вася не сможет пролезть");
            }
        }
        public static void Ex2()
        {
            Console.WriteLine("Задача:напечатать таблицу умножения на число, введенное пользователем");
            int n = 0;
            do
            {
                Console.Write("Введите число от 1 до 9 n=");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    //
                }
            }
            while ((n < 1) || (n >= 9));
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
        }
        public static void Ex3()
        {
            Console.WriteLine("Задача:программа,которая принимает на вход данные и возвращает бэнг, бум, бэнгбум, мимо");
            Console.Write("Введите число x=");
            int x = int.Parse(Console.ReadLine());
            if (x % 15 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }

        }
        public static void Ex4()
        {
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            bool f = true;
            foreach (var symbol in str)
                if (!char.IsUpper(symbol))
                {
                    f = false;
                    break;
                }
            Console.Write(f ? "True" : "False");

        }
        public static void Ex5()
        {
            Console.WriteLine("Задача:программа считает n овец");
            Console.Write("Введите количество овец n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1} овца...");
            }
        }
        public static void Ex6()
        {
            Console.WriteLine("Задача:Найти среднее арифметическое всех чисел последовательности (без учета последнего отрицательного числа)");
            double sum = 0;
            double[] a = { 1, 2, 3, 0, -12 };
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] >= 0)
                    {
                        sum += a[i];
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }

            Console.WriteLine("Среднее арифметическое положительных чисел последовательности ={0}", sum / (a.Length - 1));
        }
        enum cards
        {
            Шестерка = 6,
            Семерка = 7,
            Восьмерка = 8,
            Девятка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туз = 14
        }
        public static void Ex7()
        {
            try
            {
                Console.WriteLine("Введите номер карты от 6 до 14:");
                int k = int.Parse(Console.ReadLine());
                if ((k < 6) || (k > 14))
                {
                    Console.WriteLine("Нужно было ввести число от 6 до 14");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Достоинство соответствующей карты: " + Enum.GetName(typeof(cards), k));//возвращает имя константы с заданным значением из перечисления

                }

            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException");
            }

        }

        public static void Ex8()
        {
            string res = "";
            string[] str = new string[] { " Hello Kitty ", " Hello Kitty ", " Barbie doll ", " fffg ", " ghfp ", " Molli doll " };
            int count = 0;
            foreach (string element in str)
            {

                if ((element == " Hello Kitty ") || (element == " Barbie doll "))
                {
                    count++;
                    res += element;
                }

            }
            Console.WriteLine("В сумке оказались: {0}", res);
            Console.WriteLine("Количество кукол в сумке: {0}", count);
        }
        public static void Ex9()
        {
            Console.Write("Введите порядковый номер дня недели:");
            try
            {
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Понедельник");
                        break;
                    case 2:
                        Console.WriteLine("Вторник");
                        break;
                    case 3:
                        Console.WriteLine("Среда");
                        break;
                    case 4:
                        Console.WriteLine("Четверг");
                        break;
                    case 5:
                        Console.WriteLine("Пятница");
                        break;
                    case 6:
                        Console.WriteLine("Суббота");
                        break;
                    case 7:
                        Console.WriteLine("Воскресенье");
                        break;
                    default:
                        Console.WriteLine("Не существует введенного номера дня недели");
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);//сообщает об ошибке, объявляя причину
            }
        }
        static int[] BubbleSort(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] > s[j])
                    {
                        int a = s[i];
                        s[i] = s[j];
                        s[j] = a;

                    }
                }
            }
            return s;
        }
        public static void Ex10()
        {
            Console.WriteLine("Отсортировать массив по возрастанию при помощи “пузырька”");
            Console.Write("Введите количество элементов в массиве: ");
            int a = int.Parse(Console.ReadLine());
            int[] s = new int[a];
            BubbleSort(s);
            Console.WriteLine("В результате сортировки был получен массив:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            Console.ReadLine();
        }
        public static void Ex11()
        {
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            a.Append(0);
            for (int i = 0; i < a.Count() - 1; i++)
            {
                if (a[i] < a[i + 1])
                {
                    continue;
                }
                else
                {
                    a[a.Length - 1] = i + 1;
                    break;
                }
            }
            if (a[a.Length - 1] == 0)
            {
                Console.WriteLine("Все элементы массива стоят по возрастанию");
            }
            else
            {
                Console.WriteLine("Элементы массива возрастают до элемента с индексом " + a[a.Length - 1]);
            }


        }
    }
}
