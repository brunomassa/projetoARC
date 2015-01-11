namespace prt
{
    partial class splash
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.amazingProgressBar1 = new GAW.AmazingProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A Ligar Bases de dados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 48;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // amazingProgressBar1
            // 
            this.amazingProgressBar1.BorderColor = System.Drawing.Color.Transparent;
            this.amazingProgressBar1.BorderGradient = false;
            this.amazingProgressBar1.BorderRoundCorners = false;
            this.amazingProgressBar1.BorderSize = 0;
            this.amazingProgressBar1.ForeColor = System.Drawing.Color.OrangeRed;
            this.amazingProgressBar1.Gradient = GAW.AmazingProgressBar.GradientType.Rows;
            this.amazingProgressBar1.GradientEndColor = System.Drawing.Color.OrangeRed;
            this.amazingProgressBar1.GradientStartColor = System.Drawing.Color.OrangeRed;
            this.amazingProgressBar1.Location = new System.Drawing.Point(17, 137);
            this.amazingProgressBar1.MazeStyle = GAW.AmazingProgressBar.MazeStyleType.SingleRight;
            this.amazingProgressBar1.Name = "amazingProgressBar1";
            this.amazingProgressBar1.RowCount = 10;
            this.amazingProgressBar1.Size = new System.Drawing.Size(255, 23);
            this.amazingProgressBar1.TabIndex = 3;
            this.amazingProgressBar1.UnusedColor = System.Drawing.Color.OrangeRed;
            this.amazingProgressBar1.WallColor = System.Drawing.Color.White;
            this.amazingProgressBar1.WallSize = 0;
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prt.Properties.Resources.img_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.amazingProgressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splash";
            this.Load += new System.EventHandler(this.splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private GAW.AmazingProgressBar amazingProgressBar1;
    }
}