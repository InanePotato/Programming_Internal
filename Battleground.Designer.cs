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
            this.components = new System.ComponentModel.Container();
            this.PNL_Battleground = new System.Windows.Forms.Panel();
            this.PNL_BattleResults = new System.Windows.Forms.Panel();
            this.BTN_BackToAC = new System.Windows.Forms.Button();
            this.LBL_BattleResults = new System.Windows.Forms.Label();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.PNL_Battle = new System.Windows.Forms.Panel();
            this.TMR_Battle = new System.Windows.Forms.Timer(this.components);
            this.TMR_Controls = new System.Windows.Forms.Timer(this.components);
            this.TMR_Attack = new System.Windows.Forms.Timer(this.components);
            this.PNL_Battleground.SuspendLayout();
            this.PNL_BattleResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Battleground
            // 
            this.PNL_Battleground.BackgroundImage = global::Programming_Internal.Properties.Resources.Battleground_Background2;
            this.PNL_Battleground.Controls.Add(this.PNL_BattleResults);
            this.PNL_Battleground.Controls.Add(this.PNL_Battle);
            this.PNL_Battleground.Location = new System.Drawing.Point(0, 0);
            this.PNL_Battleground.Name = "PNL_Battleground";
            this.PNL_Battleground.Size = new System.Drawing.Size(886, 714);
            this.PNL_Battleground.TabIndex = 0;
            // 
            // PNL_BattleResults
            // 
            this.PNL_BattleResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PNL_BattleResults.Controls.Add(this.BTN_BackToAC);
            this.PNL_BattleResults.Controls.Add(this.LBL_BattleResults);
            this.PNL_BattleResults.Controls.Add(this.LBL_Title);
            this.PNL_BattleResults.ForeColor = System.Drawing.SystemColors.Control;
            this.PNL_BattleResults.Location = new System.Drawing.Point(142, 183);
            this.PNL_BattleResults.Name = "PNL_BattleResults";
            this.PNL_BattleResults.Size = new System.Drawing.Size(600, 400);
            this.PNL_BattleResults.TabIndex = 1;
            this.PNL_BattleResults.Visible = false;
            // 
            // BTN_BackToAC
            // 
            this.BTN_BackToAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_BackToAC.FlatAppearance.BorderSize = 0;
            this.BTN_BackToAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BackToAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BackToAC.Location = new System.Drawing.Point(0, 320);
            this.BTN_BackToAC.Name = "BTN_BackToAC";
            this.BTN_BackToAC.Size = new System.Drawing.Size(600, 80);
            this.BTN_BackToAC.TabIndex = 2;
            this.BTN_BackToAC.Text = "Back To Army Camp";
            this.BTN_BackToAC.UseVisualStyleBackColor = false;
            this.BTN_BackToAC.Click += new System.EventHandler(this.BTN_BackToAC_Click);
            // 
            // LBL_BattleResults
            // 
            this.LBL_BattleResults.BackColor = System.Drawing.Color.Transparent;
            this.LBL_BattleResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BattleResults.Location = new System.Drawing.Point(0, 120);
            this.LBL_BattleResults.Name = "LBL_BattleResults";
            this.LBL_BattleResults.Size = new System.Drawing.Size(600, 150);
            this.LBL_BattleResults.TabIndex = 1;
            this.LBL_BattleResults.Text = "Casualties: 00000\r\nEnemies Killed: 00000\r\nCoins Earned: 00000";
            this.LBL_BattleResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Title
            // 
            this.LBL_Title.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(0, 10);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(600, 76);
            this.LBL_Title.TabIndex = 0;
            this.LBL_Title.Text = "Victory!!";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_Battle
            // 
            this.PNL_Battle.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Battle.Location = new System.Drawing.Point(0, 375);
            this.PNL_Battle.Name = "PNL_Battle";
            this.PNL_Battle.Size = new System.Drawing.Size(886, 240);
            this.PNL_Battle.TabIndex = 0;
            this.PNL_Battle.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Battle_Paint);
            // 
            // TMR_Battle
            // 
            this.TMR_Battle.Tick += new System.EventHandler(this.TMR_Battle_Tick);
            // 
            // TMR_Controls
            // 
            this.TMR_Controls.Tick += new System.EventHandler(this.TMR_Controls_Tick);
            // 
            // TMR_Attack
            // 
            this.TMR_Attack.Tick += new System.EventHandler(this.TMR_Attack_Tick);
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
            this.PNL_Battleground.ResumeLayout(false);
            this.PNL_BattleResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Battleground;
        private System.Windows.Forms.Panel PNL_Battle;
        private System.Windows.Forms.Timer TMR_Battle;
        private System.Windows.Forms.Timer TMR_Controls;
        private System.Windows.Forms.Timer TMR_Attack;
        private System.Windows.Forms.Panel PNL_BattleResults;
        private System.Windows.Forms.Button BTN_BackToAC;
        private System.Windows.Forms.Label LBL_BattleResults;
        private System.Windows.Forms.Label LBL_Title;
    }
}