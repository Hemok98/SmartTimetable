using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTimetable
{
    class Lesson
    {
        private bool lection;

        static string GetLessonName(int id)
        {
           
            switch (id)
            {
                case 1 : return "Английский язык"; break;
                case 2 : return "Алгоритмы и структуры данных"; break;
                case 3 : return "Дифуры"; break;
                case 4 : return "Python"; break;
                case 5 : return "Программирование"; break;
                case 6 : return "Немецкий язык"; break;
                case 7 : return "Мат логика"; break;
                case 8 : return "Мат анализ"; break;
                case 9 : return "Системы реального времени"; break;
                case 10 : return "Физра"; break;
                default: return "";
            }
        }
    }
}
