namespace Programming_Internal
{
    partial class Battleground
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
            this.PNL_Battleground = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_Battleground
            // 
            this.PNL_Battleground.BackgroundImage = global::Programming_Internal.Properties.Resources.Battleground_Background2;
            this.PNL_Battleground.Location = new System.Drawing.Point(0, 0);
            this.PNL_Battleground.Name = "PNL_Battleground";
            this.PNL_Battleground.Size = new System.Drawing.Size(886, 714);
            this.PNL_Battleground.TabIndex = 0;
            // 
            // Battleground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.PNL_Battleground);
            this.Name = "Battleground";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Battleground_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Battleground;
    }
}