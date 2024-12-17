using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {// Вводим номер месяца
            Console.Write("Введите номер месяца (от 1 до 12): ");
            int month = int.Parse(Console.ReadLine());

            // Используем switch для определения времени года
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Неверный номер месяца. Введите число от 1 до 12.");
                    break;
            }

            // Ожидаем нажатия клавиши перед закрытием программы
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
    

