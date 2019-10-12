using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTimetable
{ 
    class LessonPanel : Panel
    {
        private Button lessonNum;
        public LessonPanel(int xPos, int yPos,int lessonNum) : base()
        {
            this.SuspendLayout();

            //controls init

            this.lessonNum = new Button();
            this.lessonNum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lessonNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lessonNum.Location = new System.Drawing.Point(1, 1);
            this.lessonNum.Name = "lessonNum";
            this.lessonNum.Size = new System.Drawing.Size(18, 30);
            this.lessonNum.TabIndex = 14;
            this.lessonNum.Text = (lessonNum+1).ToString();
            this.Controls.Add(this.lessonNum);

            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Visible = true;
            this.Location = new System.Drawing.Point(xPos, yPos);
            this.Name = "lesson" + lessonNum.ToString() ;
            this.Size = new System.Drawing.Size(400, 32);
            this.TabIndex = 5;

            this.ResumeLayout(false);
        }
    }
}
