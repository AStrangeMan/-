using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] mas;
            int i, j, w;
            string str;
            mas = new int[4][];
            mas[0] = new int[21];
            mas[1] = new int[21];
            mas[2] = new int[31];
            mas[3] = new int[10]; 
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("1- Присвоить кабинет");
            Console.WriteLine("2- Убрать метку присваивания");
            switch (w)
            {
                case 1:
                    Console.Write("Введите этаж:");
                    i = int.Parse(Console.ReadLine());
                    Console.Write("Введите кабинет:");
                    j = int.Parse(Console.ReadLine());
                    str = Console.ReadLine();
                    if (i > 3 | mas[i].Length < j)
                    {
                        Console.WriteLine("Ошибка");

                    }
                    else
                    {
                        if (mas[i][j] == 1)
                        {
                            Console.WriteLine($"{i}{j} Занят преподавателем- ({str})");
                        }
                        {
                            mas[i][j] = 1;
                            Console.WriteLine($"{i}{j} Присвоен преподавателем- ({str})");
                        }

                    }
                    break;
                case 2:
                    {
                        Console.Write("Введите этаж:");
                        i = int.Parse(Console.ReadLine());
                        Console.Write("Введите кабинет:");
                        j = int.Parse(Console.ReadLine());
                        mas[i][j] = (mas[i][j] - 1);
                    }
                    break;
            }
        }
    }
}
