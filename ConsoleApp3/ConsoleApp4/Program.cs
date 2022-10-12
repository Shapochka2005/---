internal class Program
{
    static void Main()
    {
        int[,] Octavi = new[,]
        {
                { 523, 554, 587, 622, 659, 699, 740, 784, 830, 880, 932, 988 },
                { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976},
                { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951},
        };

        Console.WriteLine("Введите номер октавы, F1, F2, F3");

        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.F1)
        {
            Console.Clear();
            Console.WriteLine("Введите номер октавы, F1, F2, F3");
            Console.WriteLine("Вы на 1 октаве");
            SmenaOktavi(Octavi, key.Key, 0);
        }
        if (key.Key == ConsoleKey.F2)
        {
            Console.Clear();
            Console.WriteLine("Введите номер октавы, F1, F2, F3");
            Console.WriteLine("Вы на 2 октаве");
            SmenaOktavi(Octavi, key.Key, 1);
        }
        if (key.Key == ConsoleKey.F3)
        {
            Console.Clear();
            Console.WriteLine("Введите номер октавы, F1, F2, F3");
            Console.WriteLine("Вы на 3 октаве");
            SmenaOktavi(Octavi, key.Key, 2);
        }
        if (key.Key == ConsoleKey.F4)
        {
            Environment.Exit(0);
        }
    }

    static void SmenaOktavi(int[,] Octavi, ConsoleKey key, int nomerOktavi)
    {
        Octava1(Octavi, key, nomerOktavi);
    }

    static void Octava1(int[,] Octavi, ConsoleKey key, int a)
    {
        while (key == ConsoleKey.F1 || key == ConsoleKey.F2 || key == ConsoleKey.F3)
        {
            ConsoleKeyInfo key2 = Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Введите номер октавы, F1, F2, F3");

            if (key2.Key == ConsoleKey.Z)
            {
                Console.Beep(Octavi[a, 0], 1000);
            }
            if (key2.Key == ConsoleKey.S)
            {
                Console.Beep(Octavi[a, 1], 1000);
            }
            if (key2.Key == ConsoleKey.X)
            {
                Console.Beep(Octavi[a, 2], 1000);
            }
            if (key2.Key == ConsoleKey.D)
            {
                Console.Beep(Octavi[a, 3], 1000);
            }
            if (key2.Key == ConsoleKey.C)
            {
                Console.Beep(Octavi[a, 4], 1000);
            }
            if (key2.Key == ConsoleKey.F)
            {
                Console.Beep(Octavi[a, 5], 1000);
            }
            if (key2.Key == ConsoleKey.V)
            {
                Console.Beep(Octavi[a, 6], 1000);
            }
            if (key2.Key == ConsoleKey.G)
            {
                Console.Beep(Octavi[a, 7], 1000);
            }
            if (key2.Key == ConsoleKey.B)
            {
                Console.Beep(Octavi[a, 8], 1000);
            }
            if (key2.Key == ConsoleKey.H)
            {
                Console.Beep(Octavi[a, 9], 1000);
            }
            if (key2.Key == ConsoleKey.N)
            {
                Console.Beep(Octavi[a, 10], 1000);
            }
            if (key2.Key == ConsoleKey.J)
            {
                Console.Beep(Octavi[a, 11], 1000);
            }
            if (key2.Key == ConsoleKey.F1)
            {
                Console.Clear();
                Console.WriteLine("Вы на 1 октаве");
                SmenaOktavi(Octavi, key2.Key, 0);
            }
            if (key2.Key == ConsoleKey.F2)
            {
                Console.Clear();
                Console.WriteLine("Вы на 2 октаве");
                SmenaOktavi(Octavi, key2.Key, 1);
            }
            if (key2.Key == ConsoleKey.F3)
            {
                Console.Clear();
                Console.WriteLine("Вы на 3 октаве");
                SmenaOktavi(Octavi, key2.Key, 2);
            }
            if (key2.Key == ConsoleKey.F4)
            {
                Environment.Exit(0);
            }
        }
    }
}
