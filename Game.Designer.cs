namespace Programming_Internal
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PNL_Game = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PNL_Game
            // 
            this.PNL_Game.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PNL_Game.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PNL_Game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PNL_Game.Location = new System.Drawing.Point(0, 0);
            this.PNL_Game.Name = "PNL_Game";
            this.PNL_Game.Size = new System.Drawing.Size(886, 762);
            this.PNL_Game.TabIndex = 0;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.PNL_Game);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Song - But It\'s A Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Game;
    }
}

