using System.Windows.Forms;

namespace GithubRepos
{
    partial class Setings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Setings";
            this.FontColor = new Button();
            this.FontColor.Size = new System.Drawing.Size(100,50);
            this.FontColor.Location = new System.Drawing.Point(this.Width/2-this.FontColor.Size.Width,this.Height/2-this.FontColor.Size.Height);
            this.FontColor.Text = "Font Color";
            this.FontColor.Click += FontColor_Click;

            this.BackColor = new Button();
            this.BackColor = new Button();
            this.BackColor.Size = new System.Drawing.Size(100, 50);
            this.BackColor.Location = new System.Drawing.Point(this.Width / 2 - this.FontColor.Size.Width, this.Height / 2);
            this.BackColor.Text = "Back Color";
            this.BackColor.Click += BackColor_Click;

            this.Controls.Add(FontColor);
            this.Controls.Add(BackColor);

        }

        private void FontColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog FontColor = new ColorDialog();




        }

        private void BackColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog BackColor = new ColorDialog();


        }

        private Button FontColor;
        private Button BackColor;
        #endregion
    }
}