using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    { /// <summary>
      /// Дано целое число n, указывающее номер дня недели от 1 до 7. По указанному номеру n вывести название соответствующего дня недели.
      /// </summary>
        
        
            static int Input(string mes)
            {
                Console.Write(mes);
                return int.Parse(Console.ReadLine());
            }

            static void Main(string[] args)
            {
                int day = Input("day=");
                string d = GetDay(day);
                Console.WriteLine(GetDay(day));
                Console.ReadKey();

            }

            static string GetDay(int day)
            {
                switch (day)
                {
                    case 1: return "Понедельник";
                    case 2: return "Вторник";
                    case 3: return "Среда";
                    case 4: return "Четверг";
                    case 5: return "Пятница";
                    case 6: return "Суббота";
                    case 7: return "Воскресение";
                    default: return "Ошибка";

                }
            }

        }
    }






