namespace Programming_Internal
{
    partial class Map
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
            this.PNL_LevelDisplay = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_LevelDisplay
            // 
            this.PNL_LevelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PNL_LevelDisplay.Location = new System.Drawing.Point(145, 93);
            this.PNL_LevelDisplay.Name = "PNL_LevelDisplay";
            this.PNL_LevelDisplay.Size = new System.Drawing.Size(600, 500);
            this.PNL_LevelDisplay.TabIndex = 0;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming_Internal.Properties.Resources.Battleground_Background2;
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.PNL_LevelDisplay);
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_LevelDisplay;
    }
}