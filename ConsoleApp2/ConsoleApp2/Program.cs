using System.ComponentModel;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("1. Угадай число \n" +
                "2. Таблица умножения \n" +
                "3. Вывод делителей числа \n" +
                "4. Выход из программы");
            Console.Write("Введите номер операции: ");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Prog1();
            }
            if (op == 2)
            {
                Prog2();
            }
            if (op == 3)
            {
                Prog3();
            }
            if(op == 4)
            {
                Environment.Exit(0);
            }
        }

        static void Prog1()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 1);

            Console.Write("Введите число от 0 до 100: ");

            int b = Convert.ToInt32(Console.ReadLine());
            while (b != a)
            {
                Console.WriteLine("Неверно, попробуйте ещё раз");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Верно, вы угадали число");
            Main();
        }

        static void Prog2()
        {
            int[,] a = new int[11, 11];

            for (int i = 1; i < 11; ++i)
            {
                for (int j = 1; j < 11; ++j)
                {
                    a[i, j] = i * j;
                }
            }
            for (int i = 1; i < 11; ++i)
            {
                for (int j = 1; j < 11; ++j)
                {
                    Console.Write("{0, 4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Main();
        }

        static void Prog3()
        {
           
            Console.WriteLine("Введите число: ");

                int a = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            Main();
        }
    }
}
