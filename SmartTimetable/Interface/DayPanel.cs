using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTimetable
{
    class DayPanel : Panel
    {
        private LessonPanel[] lessons = new LessonPanel[6];

        public DayPanel(int xPos, int yPos, int dayNum) : base()
        {
            this.SuspendLayout();

            this.BackColor = System.Drawing.Color.LightGray;
            this.Visible = true;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Name = "day" + dayNum.ToString();
            this.Size = new System.Drawing.Size(440, 230);
            this.TabIndex = 5;

            //controls init
            for (int i = 0; i < 6; i++)
            {
                this.lessons[i] = new LessonPanel(30, 2 + i * 34, i);
                this.Controls.Add(this.lessons[i]);
            }

            

            this.ResumeLayout(false);
        }
    }
}
