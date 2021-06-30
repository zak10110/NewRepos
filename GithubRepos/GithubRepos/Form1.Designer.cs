
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GithubRepos
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Bitmap shester = new Bitmap("Shester.png");
            FormSetings = new Setings();

            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.Load += Form1_Load;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(178, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 182);
            this.label1.TabIndex = 0;
            this.label1.Text = "";
            this.label1.BackColor = Color.DarkCyan;
            this.label1.ForeColor = Color.Aquamarine;
            this.label1.Click += new System.EventHandler(this.label1_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            timer = new Timer();
            timer.Tick += Timer_Tick;

            this.Btn_Setings = new Button();
            this.Btn_Setings.Size = new Size(50,50);
            this.Btn_Setings.Location = new Point(this.Width-this.Btn_Setings.Size.Width,0);
            this.Btn_Setings.BackgroundImage= shester;
            this.Btn_Setings.BackgroundImageLayout = ImageLayout.Stretch;
            this.Btn_Setings.Click += Btn_Setings_Click;

            this.Controls.Add(Btn_Setings);

        }

        private void Btn_Setings_Click(object sender, EventArgs e)
        {
            FormSetings.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            string time = "";

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            if (h < 10)
            {
                time += "0" + h;
            }
            else
            {
                time += h;
            }

            time += ":";

            if (m < 10)
            {
                time += "0" + m;
            }
            else
            {
                time += m;
            }

            time += ":";

            if (s < 10)
            {
                time += "0" + s;
            }
            else
            {
                time += s;
            }

            this.label1.Text = time;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

            timer.Interval = 1000;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }

        #endregion
        private Timer timer;
        private Button Btn_Setings;
        private Setings FormSetings;

        private System.Windows.Forms.Label label1;
    }
}

