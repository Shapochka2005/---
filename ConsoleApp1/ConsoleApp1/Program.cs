namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0;

            while (c < 1) {

                Console.ForegroundColor = ConsoleColor.Green;

                Console.Write("1. Сложить 2 числа\n" +

                    "2. Вычесть первое из второго\n" +

                    "3. Перемножить два числа\n" +

                    "4. Разделить первое на второе\n" +

                    "5. Возвести в степень N первое число\n" +

                    "6. Найти квадратный корень из числа\n" +

                    "7. Найти 1 процент от числа\n" +

                    "8. Найти факториал из числа\n" +

                    "9. Выйти из программы\n");

                Console.Write("Введите номер действия: ");

                int deystvie =Convert.ToInt32(Console.ReadLine());

                
                //Первое действие 

                if (deystvie == 1)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    Console.Write("Введите 2 число: ");

                    string input3 = Console.ReadLine();
                    int chislo2 = Convert.ToInt32(input3);
                    Console.WriteLine(chislo1 + chislo2);
                }
                else

                //Второе действие 

                if (deystvie == 2)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    Console.Write("Введите 2 число: ");

                    string input3 = Console.ReadLine();
                    int chislo2 = Convert.ToInt32(input3);

                    Console.WriteLine(chislo2 - chislo1);

                }else

                //Третье действие 

                if (deystvie == 3)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    Console.Write("Введите 2 число: ");

                    string input3 = Console.ReadLine();
                    int chislo2 = Convert.ToInt32(input3);

                    Console.WriteLine(chislo1 * chislo2);

                }else

                //Четвёртое действие 

                if (deystvie == 4)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    Console.Write("Введите 2 число: ");

                    string input3 = Console.ReadLine();
                    int chislo2 = Convert.ToInt32(input3);

                    Console.WriteLine(chislo1 / chislo2);

                }else

                //Пятое действие 

                if (deystvie == 5)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    int N = Console.Read();
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write(chislo1 * chislo1);
                    }

                } else

                //Шестое действие 

                if (deystvie == 6)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);

                    Console.WriteLine(Math.Sqrt(chislo1));

                }else

                //Седьмое действие 

                if (deystvie == 7)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);


                    Console.WriteLine(chislo1 * 0.01);

                }else

                //Восьмое действие 

                if (deystvie == 8)
                {
                    Console.Write("Введите 1 число: ");

                    string input2 = Console.ReadLine();
                    int chislo1 = Convert.ToInt32(input2);


                    for (int i = 1; i <= chislo1; i++)
                    {
                        chislo1 *= i;
                    }
                    Console.WriteLine(chislo1);

                }
            }
        }

    }

}