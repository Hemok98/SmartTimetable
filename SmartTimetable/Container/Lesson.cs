using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTimetable
{
    class Lesson
    {
        private string date;
        private int lessonNumber;
        private int division; //0 - all, 1 - groups, 2 - subgroups
        private bool[] groups = new bool[3]; //what group has lesson
        private int[] lessonIds = new int[3]; 
        private bool[] changed = new bool[3]; //is lesson timetable was changed
        private string[] homework = new string[3];

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

        public Lesson(int number,string date)
        {
            this.date = date;
            this.lessonNumber = number;
            this.division = 0;
            for (int i = 0; i < 3; i++)
            {
                this.groups[i] = false;
                this.lessonIds[i] = 0;
                this.changed[i] = false;
                this.homework[i] = "";
            }
        }
    }
}
