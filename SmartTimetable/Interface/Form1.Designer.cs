namespace SmartTimetable
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeNewsPanel()
        {
            this.SuspendLayout();
            this.newsPanel = new System.Windows.Forms.Panel();
            this.newsPanel.AutoScroll = true;
            this.newsPanel.AutoScrollMargin = new System.Drawing.Size(8, 10);
            this.newsPanel.SuspendLayout();
            this.newsPanel.BackColor = System.Drawing.Color.FromArgb(40,100,100,100);
            this.newsPanel.Visible = true;
            this.newsPanel.Location = new System.Drawing.Point(907, 40);
            this.newsPanel.Name = "week";
            this.newsPanel.Size = new System.Drawing.Size(290, 630);
            this.newsPanel.TabIndex = 5;
            this.Controls.Add(this.newsPanel);
            //controls init


            string html = null;
            try
            {
                using (System.Net.WebClient web = new System.Net.WebClient())
                {
                    html = web.DownloadString("http://2mobfu.tilda.ws/");
                }
            }
            catch (System.Net.WebException ex)
            {
                System.Net.HttpWebResponse httpResp = (System.Net.HttpWebResponse)ex.Response;
                if (ex.Status == System.Net.WebExceptionStatus.ProtocolError && httpResp.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    // Страница не найдена
                }
                else throw;
            }

            System.Text.Encoding utf8 = System.Text.Encoding.GetEncoding("UTF-8");
            System.Text.Encoding win1251 = System.Text.Encoding.GetEncoding("Windows-1251");

            byte[] utf8Bytes = win1251.GetBytes(html);
            byte[] win1251Bytes = System.Text.Encoding.Convert(utf8, win1251, utf8Bytes);

            //Console.WriteLine(win1251.GetString(win1251Bytes));

            html = win1251.GetString(win1251Bytes);
            //int indexOfSubstring = html.IndexOf(<!-- T004 -->); // равно 6
            html = html.Substring(html.IndexOf("News start") + 10);
            html = html.Substring(0, html.IndexOf("News end") - 5);


            int kolvo = 0;
            for (int i = 0; i < html.Length; i++)
            {
                if (html[i] == '>') kolvo++;
            }

            int index = 0;
            this.newsButtons = new System.Windows.Forms.Button[kolvo];
            for (int i = 0; i < kolvo; i++)
            {
                this.newsButtons[i] = new System.Windows.Forms.Button();
                this.newsButtons[i].BackColor = System.Drawing.SystemColors.ActiveCaption;
                this.newsButtons[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.newsButtons[i].Location = new System.Drawing.Point(5, 2 + i * 95);
                this.newsButtons[i].Name = "newsButtons[i]";
                this.newsButtons[i].Size = new System.Drawing.Size(260, 90);
                this.newsButtons[i].TabIndex = 14;
                this.newsButtons[i].Text = i.ToString();
                this.newsButtons[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.newsPanel.Controls.Add(this.newsButtons[i]);
            }

            while (html.IndexOf(">") > -1)
            {
                html = html.Substring(html.IndexOf(">") + 1);
                string output = html.Substring(0, html.IndexOf("<"));
                html = html.Substring(html.IndexOf("<") + 1);
                this.newsButtons[index].Text = output;
                index++;

            }

            
            

            this.newsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.week = new WeekPanel(5, 5);
            this.Controls.Add(this.week);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 710);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private WeekPanel week;
        private System.Windows.Forms.Panel newsPanel;
        private System.Windows.Forms.Button[] newsButtons;
    }
}

