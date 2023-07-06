using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 19 ");
            Zd19();
            Console.WriteLine("Задача 21 ");
            Zd21();
            Console.WriteLine("Задача 22 ");
            Zd22();

            Console.ReadKey();

        }
        static void Zd19()
        {
            //Задача 19
            //Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 0 1 2 3 4
            //14212 -> нет
            //12821 -> да
            //23432 -> да
            string meaning = Convert.ToString(Console.ReadLine());
            if (meaning.Length > 4)
            {
                if (meaning[0] == meaning[4] && meaning[1] == meaning[3])
                {
                    Console.WriteLine($"Значение {meaning} является палидромом !");
                }
                else
                {
                    Console.WriteLine($"Значение {meaning} НЕ является палидромом или введено не корректное значение");

                }
            }
            else
            {
                Console.WriteLine($"Значение {meaning} не является пятизначным  ");
            }

        }
        static void Zd21()
        {
            //Задача 21
            //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
            //A(3, 6, 8); B(2, 1, -7), -> 15.84
            //A(7, -5, 0); B(1, -1, 9)-> 11.53
            Console.WriteLine("числа для А :");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int a2 = Convert.ToInt32(Console.ReadLine());
            int a3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("числа для B :");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int b3 = Convert.ToInt32(Console.ReadLine());

            double resultAB = Math.Sqrt(Math.Pow(a1 - b1, 2) + Math.Pow(a2 - b2, 2) + Math.Pow(a3 - b3, 2));

            Console.WriteLine(Math.Round(resultAB, 2));
        }
        static void Zd22()
        {
            //Задача 22: Напишите программу, которая принимает на вход число(N) и выдаёт таблицу квадратов чисел от 1 до N.
            //5-> 1, 4, 9, 16, 25.
            //2-> 1,4

            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.Write( Math.Pow(i, 2)+ " " );
            }
        }
    }

}
