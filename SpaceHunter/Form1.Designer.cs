namespace SpaceHunter
{
    partial class Form1
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
            this.Hunter = new System.Windows.Forms.PictureBox();
            this.Platform = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hunter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).BeginInit();
            this.SuspendLayout();
            // 
            // Hunter
            // 
            this.Hunter.BackColor = System.Drawing.Color.White;
            this.Hunter.BackgroundImage = global::SpaceHunter.Properties.Resources.snippet;
            this.Hunter.Image = global::SpaceHunter.Properties.Resources.bomber_sprite;
            this.Hunter.Location = new System.Drawing.Point(340, 547);
            this.Hunter.Margin = new System.Windows.Forms.Padding(0);
            this.Hunter.Name = "Hunter";
            this.Hunter.Size = new System.Drawing.Size(60, 50);
            this.Hunter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hunter.TabIndex = 1;
            this.Hunter.TabStop = false;
            this.Hunter.Tag = "Hunter";
            // 
            // Platform
            // 
            this.Platform.BackColor = System.Drawing.Color.OliveDrab;
            this.Platform.Image = global::SpaceHunter.Properties.Resources.fly_ground;
            this.Platform.Location = new System.Drawing.Point(0, 600);
            this.Platform.Name = "Platform";
            this.Platform.Size = new System.Drawing.Size(782, 246);
            this.Platform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Platform.TabIndex = 0;
            this.Platform.TabStop = false;
            this.Platform.Tag = "Platform";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceHunter.Properties.Resources.star_sky;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.Hunter);
            this.Controls.Add(this.Platform);
            this.Name = "Form1";
            this.Text = "SPACE HUNTER";
            this.Load += new System.EventHandler(this.Start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_Hunter);
            ((System.ComponentModel.ISupportInitialize)(this.Hunter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Platform;
        private System.Windows.Forms.PictureBox Hunter;
    }
}

