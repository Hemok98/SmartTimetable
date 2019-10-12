using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTimetable
{
    class Day
    {
        private Lesson[] lessons = new Lesson[6];
        private string dayDescription;
        private int dayNumber;
        private string date;

        public Day(int number, string date)
        {
            this.dayDescription = "";
            this.dayNumber = number;
            this.date = date;
            for (int i = 0; i < 6; i++)
            {
                this.lessons[i] = new Lesson(i, this.date);
            }
        }
    }
}
