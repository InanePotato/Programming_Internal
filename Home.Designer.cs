namespace Programming_Internal
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BTN_Play = new System.Windows.Forms.Button();
            this.PIC_Title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Play
            // 
            this.BTN_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Play.Location = new System.Drawing.Point(283, 369);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(200, 60);
            this.BTN_Play.TabIndex = 0;
            this.BTN_Play.Text = "Play Game";
            this.BTN_Play.UseVisualStyleBackColor = true;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // PIC_Title
            // 
            this.PIC_Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIC_Title.BackgroundImage = global::Programming_Internal.Properties.Resources.TitleImage;
            this.PIC_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PIC_Title.Location = new System.Drawing.Point(180, 30);
            this.PIC_Title.Name = "PIC_Title";
            this.PIC_Title.Size = new System.Drawing.Size(387, 150);
            this.PIC_Title.TabIndex = 1;
            this.PIC_Title.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PIC_Title);
            this.Controls.Add(this.BTN_Play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Game";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.PictureBox PIC_Title;
    }
}