using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTimetable
{
    class Week
    {
        private Day[] days = new Day[6];
        private int weekNumber;
        private string startDayWeek;

        public Week(int num, string date)
        {
            this.startDayWeek = date;
            this.weekNumber = num;
            for (int i = 0; i < 6; i++)
            {
                this.days[i] = new Day(i, this.startDayWeek + i.ToString());
            }
        }
    }
}
