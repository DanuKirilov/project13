using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вводим первую букву предмета
            Console.Write("Введите первую букву предмета (ф, м, и, г, б): ");
            char letter = char.ToLower(Console.ReadKey().KeyChar);  // Читаем символ и преобразуем в нижний регистр

            // Используем switch для определения предмета
            switch (letter)
            {
                case 'ф':
                    Console.WriteLine("\nФизика");
                    break;
                case 'м':
                    Console.WriteLine("\nМатематика");
                    break;
                case 'и':
                    Console.WriteLine("\nИстория");
                    break;
                case 'г':
                    Console.WriteLine("\nГеография");
                    break;
                case 'б':
                    Console.WriteLine("\nБиология");
                    break;
                default:
                    Console.WriteLine("\nНеверная буква. Введите ф, м, и, г, или б.");
                    break;
            }

            // Ожидаем нажатия клавиши перед закрытием программы
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
    

