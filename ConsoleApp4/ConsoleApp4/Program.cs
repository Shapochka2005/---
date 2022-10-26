using System.Runtime.InteropServices;

internal class Program
{
    static void Main()
    {
        Console.Clear();
        int date = 26;
        int month = 10;
        int year = 2022;
        int[] mass = new int[] { date, month, year };
        int position = 3;

        Console.Write("Выбранная дата: ");
        Console.Write(mass[0]);
        Console.Write(".");
        Console.Write(mass[1]);
        Console.Write(".");
        Console.WriteLine(mass[2]);
        Console.WriteLine("Дела на сегодня: ");
        Console.WriteLine("  Пойти на барабаны");
        Console.WriteLine("  Идти гулять");
        Console.WriteLine("  Пить пиво");
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            perehod(key, position, mass);
            if (key.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                mass[0]++;
                if (mass[0] == 32)
                {
                    mass[0] = 1;
                    mass[1]++;
                }
                if (mass[1] == 12)
                {
                    mass[1] = 1;
                    mass[2]++;
                }
                Console.Clear();
                Console.Write("Выбранная дата: ");
                Console.Write(mass[0]);
                Console.Write(".");
                Console.Write(mass[1]);
                Console.Write(".");
                Console.WriteLine(mass[2]);
                Console.WriteLine("Дела на сегодня: ");
                if (mass[0] == 26)
                {
                    Console.WriteLine("  Пойти на барабаны");
                    Console.WriteLine("  Идти гулять");
                    Console.WriteLine("  Пить пиво");
                }
                if (mass[0] == 27)
                {
                    Console.WriteLine("  Пойти");
                    Console.WriteLine("  Идти");
                    Console.WriteLine("  Купаться");
                }

            }

            {
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    mass[0]--;

                    if (mass[0] == 0)
                    {
                        mass[0] = 31;
                        mass[1]--;
                    }
                    if (mass[1] == 1)
                    {
                        mass[1] = 12;
                        mass[2]--;
                    }
                    Console.Write("Выбранная дата: ");
                    Console.Write(mass[0]);
                    Console.Write(".");
                    Console.Write(mass[1]);
                    Console.Write(".");
                    Console.WriteLine(mass[2]);
                    Console.WriteLine("Дела на сегодня: ");
                    if (mass[0] == 26)
                    {
                        Console.WriteLine("  Пойти на барабаны");
                        Console.WriteLine("  Идти гулять");
                        Console.WriteLine("  Пить пиво");
                    }
                    if (mass[0] == 27)
                    {
                        Console.WriteLine("  Пойти");
                        Console.WriteLine("  Идти");
                        Console.WriteLine("  Купаться");
                    }
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("->");
                    Console.Clear();
                    Console.Write("Выбранная дата: ");
                    Console.Write(mass[0]);
                    Console.Write(".");
                    Console.Write(mass[1]);
                    Console.Write(".");
                    Console.WriteLine(mass[2]);
                    Console.WriteLine("Дела на сегодня: ");
                    if (mass[0] == 26)
                    {
                        Console.WriteLine("  Пойти на барабаны");
                        Console.WriteLine("  Идти гулять");
                        Console.WriteLine("  Пить пиво");
                    }
                    if (mass[0] == 27)
                    {
                        Console.WriteLine("  Пойти");
                        Console.WriteLine("  Идти");
                        Console.WriteLine("  Купаться");
                    }
                    position--;
                    if (position == 1)
                    {
                        position = 2;
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("->");
                    Console.Clear();
                    Console.Write("Выбранная дата: ");
                    Console.Write(mass[0]);
                    Console.Write(".");
                    Console.Write(mass[1]);
                    Console.Write(".");
                    Console.WriteLine(mass[2]);
                    Console.WriteLine("Дела на сегодня: ");
                    if (mass[0] == 26)
                    {
                        Console.WriteLine("  Пойти на барабаны");
                        Console.WriteLine("  Идти гулять");
                        Console.WriteLine("  Пить пиво");
                    }
                    if (mass[0] == 27)
                    {
                        Console.WriteLine("  Пойти");
                        Console.WriteLine("  Идти");
                        Console.WriteLine("  Купаться");
                    }
                    position++;
                    if (position == 5)
                    {
                        position = 4;
                    }
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
            }
        }
    }
    static void perehod(ConsoleKeyInfo key, int position, int[] mass)
    {
                if (key.Key == ConsoleKey.Enter && position == 2 && mass[0] == 26)
                {
                    zametka1();
                }
                if (key.Key == ConsoleKey.Enter && position == 3 && mass[0] == 26)
                {
                    zametka2();
                }
                if (key.Key == ConsoleKey.Enter && position == 4 && mass[0] == 26)
                {
                    zametka3();
                }


                if (key.Key == ConsoleKey.Enter && position == 2 && mass[0] == 27)
                {
                    zametka4();
                }
                if (key.Key == ConsoleKey.Enter && position == 3 && mass[0] == 27)
                {
                    zametka5();
                }
                if (key.Key == ConsoleKey.Enter && position == 4 && mass[0] == 27)
                {
                    zametka6();
                }
    }            
    static void zametka1()
    {
        Console.Clear();
        Console.WriteLine("Пойти на барабаны");
        Console.WriteLine("---------------------");
        Console.WriteLine("В 20:00, 26 октября нужно сходить на барабаны.\n" +
                          "Взять с собой: Палочки                          ");
    }
    static void zametka2()
    {
        Console.Clear();
        Console.WriteLine("Идти гулять");
        Console.WriteLine("---------------------");
        Console.WriteLine("В 21:00, 26 октября нужно идти гулять.\n" +
                          "Взять с собой: Деньги                  ");
    }
    static void zametka3()
    {
        Console.Clear();
        Console.WriteLine("Пить пиво");
        Console.WriteLine("---------------------");
        Console.WriteLine("В 22:00, 26 октября нужно идти в магазин и покупать пиво.\n" +
                          "Взять с собой: Друзей                          ");
    }


    static void zametka4()
    {
        Console.Clear();
        Console.WriteLine("Пойти");
        Console.WriteLine("---------------------");
        Console.WriteLine("Просто пойти");
    }
    static void zametka5()
    {
        Console.Clear();
        Console.WriteLine("Идти");
        Console.WriteLine("---------------------");
        Console.WriteLine("Просто идти");
    }
    static void zametka6()
    {
        Console.Clear();
        Console.WriteLine("Купаться");
        Console.WriteLine("---------------------");
        Console.WriteLine("Ну да в -5 купаться, а че такого");
    }


}  