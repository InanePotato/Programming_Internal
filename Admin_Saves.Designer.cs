namespace Programming_Internal
{
    partial class Admin_Saves
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
            this.PNL_Saves = new System.Windows.Forms.Panel();
            this.listview = new System.Windows.Forms.ListView();
            this.CHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCoins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHLevelsUnlocked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHSlots = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBasicUnlockedLevelAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHRangeUnlockedLevelAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHMagicUnlockedLevelAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHGunUnlockedLevelAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHGiantUnlockedLevelAmmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LBL_Title = new System.Windows.Forms.Label();
            this.TMR_Checker = new System.Windows.Forms.Timer(this.components);
            this.PNL_Saves.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Saves
            // 
            this.PNL_Saves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_Saves.Controls.Add(this.listview);
            this.PNL_Saves.Controls.Add(this.LBL_Title);
            this.PNL_Saves.Location = new System.Drawing.Point(20, 20);
            this.PNL_Saves.Name = "PNL_Saves";
            this.PNL_Saves.Size = new System.Drawing.Size(709, 428);
            this.PNL_Saves.TabIndex = 1;
            // 
            // listview
            // 
            this.listview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.listview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHName,
            this.CHCoins,
            this.CHLevelsUnlocked,
            this.CHSlots,
            this.CHBasicUnlockedLevelAmmount,
            this.CHRangeUnlockedLevelAmmount,
            this.CHMagicUnlockedLevelAmmount,
            this.CHGunUnlockedLevelAmmount,
            this.CHGiantUnlockedLevelAmmount});
            this.listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listview.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listview.FullRowSelect = true;
            this.listview.GridLines = true;
            this.listview.HideSelection = false;
            this.listview.Location = new System.Drawing.Point(0, 40);
            this.listview.Name = "listview";
            this.listview.Size = new System.Drawing.Size(709, 388);
            this.listview.TabIndex = 4;
            this.listview.UseCompatibleStateImageBehavior = false;
            this.listview.View = System.Windows.Forms.View.Details;
            // 
            // CHName
            // 
            this.CHName.Text = "Name";
            this.CHName.Width = 150;
            // 
            // CHCoins
            // 
            this.CHCoins.Text = "Coins";
            this.CHCoins.Width = 80;
            // 
            // CHLevelsUnlocked
            // 
            this.CHLevelsUnlocked.Text = "Levels Unlocked";
            this.CHLevelsUnlocked.Width = 115;
            // 
            // CHSlots
            // 
            this.CHSlots.Text = "Slot Layout";
            this.CHSlots.Width = 220;
            // 
            // CHBasicUnlockedLevelAmmount
            // 
            this.CHBasicUnlockedLevelAmmount.Text = "Basic: Unlocked, Ammount, Level";
            this.CHBasicUnlockedLevelAmmount.Width = 215;
            // 
            // CHRangeUnlockedLevelAmmount
            // 
            this.CHRangeUnlockedLevelAmmount.Text = "Range: Unlocked, Ammount, Level";
            this.CHRangeUnlockedLevelAmmount.Width = 215;
            // 
            // CHMagicUnlockedLevelAmmount
            // 
            this.CHMagicUnlockedLevelAmmount.Text = "Magic: Unlocked, Ammount, Level";
            this.CHMagicUnlockedLevelAmmount.Width = 215;
            // 
            // CHGunUnlockedLevelAmmount
            // 
            this.CHGunUnlockedLevelAmmount.Text = "Gun: Unlocked, Ammount, Level";
            this.CHGunUnlockedLevelAmmount.Width = 215;
            // 
            // CHGiantUnlockedLevelAmmount
            // 
            this.CHGiantUnlockedLevelAmmount.Text = "Giant: Unlocked, Ammount, Level";
            this.CHGiantUnlockedLevelAmmount.Width = 215;
            // 
            // LBL_Title
            // 
            this.LBL_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBL_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.Location = new System.Drawing.Point(0, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(709, 40);
            this.LBL_Title.TabIndex = 3;
            this.LBL_Title.Text = "Saves List:";
            this.LBL_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TMR_Checker
            // 
            this.TMR_Checker.Enabled = true;
            this.TMR_Checker.Tick += new System.EventHandler(this.TMR_Checker_Tick);
            // 
            // Admin_Saves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 468);
            this.Controls.Add(this.PNL_Saves);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Saves";
            this.Text = "Admin_Saves";
            this.Load += new System.EventHandler(this.Admin_Saves_Load);
            this.PNL_Saves.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Saves;
        private System.Windows.Forms.ListView listview;
        private System.Windows.Forms.ColumnHeader CHName;
        private System.Windows.Forms.ColumnHeader CHCoins;
        private System.Windows.Forms.ColumnHeader CHLevelsUnlocked;
        private System.Windows.Forms.ColumnHeader CHSlots;
        private System.Windows.Forms.ColumnHeader CHBasicUnlockedLevelAmmount;
        private System.Windows.Forms.ColumnHeader CHRangeUnlockedLevelAmmount;
        private System.Windows.Forms.ColumnHeader CHMagicUnlockedLevelAmmount;
        private System.Windows.Forms.ColumnHeader CHGunUnlockedLevelAmmount;
        private System.Windows.Forms.ColumnHeader CHGiantUnlockedLevelAmmount;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Timer TMR_Checker;
    }
}