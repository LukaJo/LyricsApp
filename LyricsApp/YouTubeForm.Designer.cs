namespace LyricsApp
{
    partial class YouTubeForm
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
            this.pbArtist = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnYoutube = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).BeginInit();
            this.SuspendLayout();
            // 
            // pbArtist
            // 
            this.pbArtist.Location = new System.Drawing.Point(12, 12);
            this.pbArtist.Name = "pbArtist";
            this.pbArtist.Size = new System.Drawing.Size(163, 150);
            this.pbArtist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArtist.TabIndex = 0;
            this.pbArtist.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(201, 28);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(392, 20);
            this.tbTitle.TabIndex = 4;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(201, 88);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.ReadOnly = true;
            this.tbDuration.Size = new System.Drawing.Size(392, 20);
            this.tbDuration.TabIndex = 5;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(201, 142);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.ReadOnly = true;
            this.tbUrl.Size = new System.Drawing.Size(392, 20);
            this.tbUrl.TabIndex = 6;
            // 
            // btnYoutube
            // 
            this.btnYoutube.Location = new System.Drawing.Point(31, 174);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.Size = new System.Drawing.Size(116, 23);
            this.btnYoutube.TabIndex = 7;
            this.btnYoutube.Text = "Play";
            this.btnYoutube.UseVisualStyleBackColor = true;
            this.btnYoutube.Click += new System.EventHandler(this.btnYoutube_Click);
            // 
            // YouTubeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 209);
            this.Controls.Add(this.btnYoutube);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbArtist);
            this.MaximumSize = new System.Drawing.Size(621, 248);
            this.MinimumSize = new System.Drawing.Size(621, 248);
            this.Name = "YouTubeForm";
            this.Text = "YouTube";
            ((System.ComponentModel.ISupportInitialize)(this.pbArtist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArtist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnYoutube;
    }
}