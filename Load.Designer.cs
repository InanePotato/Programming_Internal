namespace Programming_Internal
{
    partial class Load
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
            this.PB_LoadProgress = new System.Windows.Forms.ProgressBar();
            this.TMR_LoadProgress = new System.Windows.Forms.Timer(this.components);
            this.LBL_LoadingText = new System.Windows.Forms.Label();
            this.TMR_EditLoadTextSuffix = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PB_LoadProgress
            // 
            this.PB_LoadProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PB_LoadProgress.Location = new System.Drawing.Point(0, 370);
            this.PB_LoadProgress.Maximum = 120;
            this.PB_LoadProgress.Name = "PB_LoadProgress";
            this.PB_LoadProgress.Size = new System.Drawing.Size(700, 30);
            this.PB_LoadProgress.Step = 1;
            this.PB_LoadProgress.TabIndex = 0;
            // 
            // TMR_LoadProgress
            // 
            this.TMR_LoadProgress.Enabled = true;
            this.TMR_LoadProgress.Tick += new System.EventHandler(this.TMR_LoadProgress_Tick);
            // 
            // LBL_LoadingText
            // 
            this.LBL_LoadingText.AutoSize = true;
            this.LBL_LoadingText.BackColor = System.Drawing.Color.Transparent;
            this.LBL_LoadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_LoadingText.Location = new System.Drawing.Point(0, 349);
            this.LBL_LoadingText.Name = "LBL_LoadingText";
            this.LBL_LoadingText.Size = new System.Drawing.Size(78, 20);
            this.LBL_LoadingText.TabIndex = 1;
            this.LBL_LoadingText.Text = "Loading...";
            // 
            // TMR_EditLoadTextSuffix
            // 
            this.TMR_EditLoadTextSuffix.Enabled = true;
            this.TMR_EditLoadTextSuffix.Interval = 200;
            this.TMR_EditLoadTextSuffix.Tick += new System.EventHandler(this.TMR_EditLoadTextSuffix_Tick);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming_Internal.Properties.Resources.LoadScreenImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.LBL_LoadingText);
            this.Controls.Add(this.PB_LoadProgress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Load";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Load_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PB_LoadProgress;
        private System.Windows.Forms.Timer TMR_LoadProgress;
        private System.Windows.Forms.Label LBL_LoadingText;
        private System.Windows.Forms.Timer TMR_EditLoadTextSuffix;
    }
}