using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTimetable
{
    class WeekPanel : Panel
    {
        private DayPanel[] days = new DayPanel[6];

        public WeekPanel(int xPos, int yPos) : base()
        {
            this.SuspendLayout();
            this.BackColor = System.Drawing.Color.Gray;
            this.Visible = true;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Name = "week";
            this.Size = new System.Drawing.Size(900, 700);
            this.TabIndex = 5;

            //controls init
            for (int i = 0; i < 6; i++)
            {
                this.days[i] = new DayPanel(2 + (i/3)*450, 2 + (i%3)*235, i);
                this.Controls.Add(this.days[i]);
            }

            

            this.ResumeLayout(false);
        }
    }
}
