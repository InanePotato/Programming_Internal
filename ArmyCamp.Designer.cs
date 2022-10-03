namespace Programming_Internal
{
    partial class ArmyCamp
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
            this.PNL_ArmyCamp = new System.Windows.Forms.Panel();
            this.PIC_MapButton = new System.Windows.Forms.PictureBox();
            this.PNL_PauseCover = new System.Windows.Forms.Panel();
            this.PIC_ShopButton = new System.Windows.Forms.PictureBox();
            this.LBL_Slot4Units = new System.Windows.Forms.Label();
            this.LBL_Slot3Units = new System.Windows.Forms.Label();
            this.LBL_Slot2Units = new System.Windows.Forms.Label();
            this.LBL_Slot1Units = new System.Windows.Forms.Label();
            this.LBL_Slot0Units = new System.Windows.Forms.Label();
            this.PNL_Slot4 = new System.Windows.Forms.Panel();
            this.PNL_Slot3 = new System.Windows.Forms.Panel();
            this.PNL_Slot2 = new System.Windows.Forms.Panel();
            this.PNL_Slot1 = new System.Windows.Forms.Panel();
            this.PNL_Slot0 = new System.Windows.Forms.Panel();
            this.PIC_KingDuck = new System.Windows.Forms.PictureBox();
            this.PNL_ACPausedCover = new System.Windows.Forms.Panel();
            this.TMR_PausePlayCheck = new System.Windows.Forms.Timer(this.components);
            this.TMR_Update = new System.Windows.Forms.Timer(this.components);
            this.PNL_ArmyCamp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MapButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ShopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_KingDuck)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_ArmyCamp
            // 
            this.PNL_ArmyCamp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(168)))), ((int)(((byte)(61)))));
            this.PNL_ArmyCamp.BackgroundImage = global::Programming_Internal.Properties.Resources.Background_ArmyCamp;
            this.PNL_ArmyCamp.Controls.Add(this.PIC_MapButton);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_PauseCover);
            this.PNL_ArmyCamp.Controls.Add(this.PIC_ShopButton);
            this.PNL_ArmyCamp.Controls.Add(this.LBL_Slot4Units);
            this.PNL_ArmyCamp.Controls.Add(this.LBL_Slot3Units);
            this.PNL_ArmyCamp.Controls.Add(this.LBL_Slot2Units);
            this.PNL_ArmyCamp.Controls.Add(this.LBL_Slot1Units);
            this.PNL_ArmyCamp.Controls.Add(this.LBL_Slot0Units);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_Slot4);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_Slot3);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_Slot2);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_Slot1);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_Slot0);
            this.PNL_ArmyCamp.Controls.Add(this.PIC_KingDuck);
            this.PNL_ArmyCamp.Controls.Add(this.PNL_ACPausedCover);
            this.PNL_ArmyCamp.Location = new System.Drawing.Point(0, 0);
            this.PNL_ArmyCamp.Name = "PNL_ArmyCamp";
            this.PNL_ArmyCamp.Size = new System.Drawing.Size(886, 714);
            this.PNL_ArmyCamp.TabIndex = 5;
            // 
            // PIC_MapButton
            // 
            this.PIC_MapButton.BackColor = System.Drawing.Color.Transparent;
            this.PIC_MapButton.BackgroundImage = global::Programming_Internal.Properties.Resources.MapSign;
            this.PIC_MapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_MapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_MapButton.Location = new System.Drawing.Point(338, 103);
            this.PIC_MapButton.Name = "PIC_MapButton";
            this.PIC_MapButton.Size = new System.Drawing.Size(128, 128);
            this.PIC_MapButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_MapButton.TabIndex = 16;
            this.PIC_MapButton.TabStop = false;
            this.PIC_MapButton.Click += new System.EventHandler(this.PIC_MapButton_Click);
            this.PIC_MapButton.MouseLeave += new System.EventHandler(this.PIC_MapButton_MouseLeave);
            this.PIC_MapButton.MouseHover += new System.EventHandler(this.PIC_MapButton_MouseHover);
            // 
            // PNL_PauseCover
            // 
            this.PNL_PauseCover.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_PauseCover.Location = new System.Drawing.Point(12, 680);
            this.PNL_PauseCover.Name = "PNL_PauseCover";
            this.PNL_PauseCover.Size = new System.Drawing.Size(23, 22);
            this.PNL_PauseCover.TabIndex = 15;
            this.PNL_PauseCover.Visible = false;
            // 
            // PIC_ShopButton
            // 
            this.PIC_ShopButton.BackColor = System.Drawing.Color.Transparent;
            this.PIC_ShopButton.BackgroundImage = global::Programming_Internal.Properties.Resources.Sign_Shop;
            this.PIC_ShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_ShopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_ShopButton.Location = new System.Drawing.Point(560, 130);
            this.PIC_ShopButton.Name = "PIC_ShopButton";
            this.PIC_ShopButton.Size = new System.Drawing.Size(128, 128);
            this.PIC_ShopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_ShopButton.TabIndex = 14;
            this.PIC_ShopButton.TabStop = false;
            this.PIC_ShopButton.Click += new System.EventHandler(this.PIC_ShopButton_Click);
            this.PIC_ShopButton.MouseLeave += new System.EventHandler(this.PIC_ShopButton_MouseLeave);
            this.PIC_ShopButton.MouseHover += new System.EventHandler(this.PIC_ShopButton_MouseHover);
            // 
            // LBL_Slot4Units
            // 
            this.LBL_Slot4Units.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Slot4Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Slot4Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Slot4Units.Location = new System.Drawing.Point(698, 661);
            this.LBL_Slot4Units.Name = "LBL_Slot4Units";
            this.LBL_Slot4Units.Size = new System.Drawing.Size(130, 27);
            this.LBL_Slot4Units.TabIndex = 13;
            this.LBL_Slot4Units.Text = "0000 Units";
            this.LBL_Slot4Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Slot3Units
            // 
            this.LBL_Slot3Units.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Slot3Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Slot3Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Slot3Units.Location = new System.Drawing.Point(557, 661);
            this.LBL_Slot3Units.Name = "LBL_Slot3Units";
            this.LBL_Slot3Units.Size = new System.Drawing.Size(130, 27);
            this.LBL_Slot3Units.TabIndex = 12;
            this.LBL_Slot3Units.Text = "0000 Units";
            this.LBL_Slot3Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Slot2Units
            // 
            this.LBL_Slot2Units.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Slot2Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Slot2Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Slot2Units.Location = new System.Drawing.Point(416, 661);
            this.LBL_Slot2Units.Name = "LBL_Slot2Units";
            this.LBL_Slot2Units.Size = new System.Drawing.Size(130, 27);
            this.LBL_Slot2Units.TabIndex = 11;
            this.LBL_Slot2Units.Text = "0000 Units";
            this.LBL_Slot2Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Slot1Units
            // 
            this.LBL_Slot1Units.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Slot1Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Slot1Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Slot1Units.Location = new System.Drawing.Point(275, 661);
            this.LBL_Slot1Units.Name = "LBL_Slot1Units";
            this.LBL_Slot1Units.Size = new System.Drawing.Size(130, 27);
            this.LBL_Slot1Units.TabIndex = 10;
            this.LBL_Slot1Units.Text = "0000 Units";
            this.LBL_Slot1Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBL_Slot0Units
            // 
            this.LBL_Slot0Units.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Slot0Units.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_Slot0Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Slot0Units.Location = new System.Drawing.Point(134, 661);
            this.LBL_Slot0Units.Name = "LBL_Slot0Units";
            this.LBL_Slot0Units.Size = new System.Drawing.Size(130, 27);
            this.LBL_Slot0Units.TabIndex = 9;
            this.LBL_Slot0Units.Text = "0000 Units";
            this.LBL_Slot0Units.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_Slot4
            // 
            this.PNL_Slot4.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Slot4.BackgroundImage = global::Programming_Internal.Properties.Resources.AC_SlotBckground;
            this.PNL_Slot4.Location = new System.Drawing.Point(698, 283);
            this.PNL_Slot4.Name = "PNL_Slot4";
            this.PNL_Slot4.Size = new System.Drawing.Size(130, 380);
            this.PNL_Slot4.TabIndex = 8;
            this.PNL_Slot4.Click += new System.EventHandler(this.PNL_Slot4_Click);
            this.PNL_Slot4.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Slot4_Paint);
            // 
            // PNL_Slot3
            // 
            this.PNL_Slot3.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Slot3.BackgroundImage = global::Programming_Internal.Properties.Resources.AC_SlotBckground;
            this.PNL_Slot3.Location = new System.Drawing.Point(557, 283);
            this.PNL_Slot3.Name = "PNL_Slot3";
            this.PNL_Slot3.Size = new System.Drawing.Size(130, 380);
            this.PNL_Slot3.TabIndex = 8;
            this.PNL_Slot3.Click += new System.EventHandler(this.PNL_Slot3_Click);
            this.PNL_Slot3.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Slot3_Paint);
            // 
            // PNL_Slot2
            // 
            this.PNL_Slot2.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Slot2.BackgroundImage = global::Programming_Internal.Properties.Resources.AC_SlotBckground;
            this.PNL_Slot2.Location = new System.Drawing.Point(416, 283);
            this.PNL_Slot2.Name = "PNL_Slot2";
            this.PNL_Slot2.Size = new System.Drawing.Size(130, 380);
            this.PNL_Slot2.TabIndex = 8;
            this.PNL_Slot2.Click += new System.EventHandler(this.PNL_Slot2_Click);
            this.PNL_Slot2.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Slot2_Paint);
            // 
            // PNL_Slot1
            // 
            this.PNL_Slot1.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Slot1.BackgroundImage = global::Programming_Internal.Properties.Resources.AC_SlotBckground;
            this.PNL_Slot1.Location = new System.Drawing.Point(275, 283);
            this.PNL_Slot1.Name = "PNL_Slot1";
            this.PNL_Slot1.Size = new System.Drawing.Size(130, 380);
            this.PNL_Slot1.TabIndex = 8;
            this.PNL_Slot1.Click += new System.EventHandler(this.PNL_Slot1_Click);
            this.PNL_Slot1.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Slot1_Paint);
            // 
            // PNL_Slot0
            // 
            this.PNL_Slot0.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Slot0.BackgroundImage = global::Programming_Internal.Properties.Resources.AC_SlotBckground;
            this.PNL_Slot0.Location = new System.Drawing.Point(134, 283);
            this.PNL_Slot0.Name = "PNL_Slot0";
            this.PNL_Slot0.Size = new System.Drawing.Size(130, 380);
            this.PNL_Slot0.TabIndex = 7;
            this.PNL_Slot0.Click += new System.EventHandler(this.PNL_Slot0_Click);
            this.PNL_Slot0.Paint += new System.Windows.Forms.PaintEventHandler(this.PNL_Slot0_Paint);
            // 
            // PIC_KingDuck
            // 
            this.PIC_KingDuck.BackColor = System.Drawing.Color.Transparent;
            this.PIC_KingDuck.Image = global::Programming_Internal.Properties.Resources.Duck_King;
            this.PIC_KingDuck.Location = new System.Drawing.Point(-14, 410);
            this.PIC_KingDuck.Name = "PIC_KingDuck";
            this.PIC_KingDuck.Size = new System.Drawing.Size(132, 138);
            this.PIC_KingDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_KingDuck.TabIndex = 4;
            this.PIC_KingDuck.TabStop = false;
            // 
            // PNL_ACPausedCover
            // 
            this.PNL_ACPausedCover.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_ACPausedCover.Enabled = false;
            this.PNL_ACPausedCover.Location = new System.Drawing.Point(28, 740);
            this.PNL_ACPausedCover.Name = "PNL_ACPausedCover";
            this.PNL_ACPausedCover.Size = new System.Drawing.Size(20, 20);
            this.PNL_ACPausedCover.TabIndex = 3;
            this.PNL_ACPausedCover.Visible = false;
            // 
            // TMR_PausePlayCheck
            // 
            this.TMR_PausePlayCheck.Enabled = true;
            this.TMR_PausePlayCheck.Tick += new System.EventHandler(this.TMR_PausePlayCheck_Tick);
            // 
            // TMR_Update
            // 
            this.TMR_Update.Enabled = true;
            this.TMR_Update.Tick += new System.EventHandler(this.TMR_Update_Tick);
            // 
            // ArmyCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.PNL_ArmyCamp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ArmyCamp";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ArmyCamp_Load);
            this.PNL_ArmyCamp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MapButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ShopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_KingDuck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_ACPausedCover;
        private System.Windows.Forms.PictureBox PIC_KingDuck;
        private System.Windows.Forms.Panel PNL_Slot0;
        private System.Windows.Forms.Panel PNL_Slot1;
        private System.Windows.Forms.Panel PNL_Slot2;
        private System.Windows.Forms.Panel PNL_Slot3;
        private System.Windows.Forms.Panel PNL_Slot4;
        private System.Windows.Forms.Label LBL_Slot0Units;
        private System.Windows.Forms.Label LBL_Slot1Units;
        private System.Windows.Forms.Label LBL_Slot2Units;
        private System.Windows.Forms.Label LBL_Slot3Units;
        private System.Windows.Forms.Label LBL_Slot4Units;
        private System.Windows.Forms.PictureBox PIC_ShopButton;
        private System.Windows.Forms.Panel PNL_ArmyCamp;
        private System.Windows.Forms.Timer TMR_PausePlayCheck;
        private System.Windows.Forms.Panel PNL_PauseCover;
        private System.Windows.Forms.Timer TMR_Update;
        private System.Windows.Forms.PictureBox PIC_MapButton;
    }
}