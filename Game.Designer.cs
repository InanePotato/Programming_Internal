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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.PNL_Game = new System.Windows.Forms.Panel();
            this.PNL_ChildForm = new System.Windows.Forms.Panel();
            this.Break_Line = new System.Windows.Forms.Panel();
            this.PNL_Top = new System.Windows.Forms.Panel();
            this.BTN_Menu = new System.Windows.Forms.Button();
            this.LBL_Coins = new System.Windows.Forms.Label();
            this.PIC_Coins = new System.Windows.Forms.PictureBox();
            this.LBL_Strength = new System.Windows.Forms.Label();
            this.PIC_Strength = new System.Windows.Forms.PictureBox();
            this.LBL_Health = new System.Windows.Forms.Label();
            this.PIC_Health = new System.Windows.Forms.PictureBox();
            this.PNL_Menu = new System.Windows.Forms.Panel();
            this.BTN_Help = new System.Windows.Forms.Button();
            this.BTN_Quit = new System.Windows.Forms.Button();
            this.BTN_MainMenu = new System.Windows.Forms.Button();
            this.TMR_ChildFromControl = new System.Windows.Forms.Timer(this.components);
            this.TMR_TopBarDisplay_Refresh = new System.Windows.Forms.Timer(this.components);
            this.PNL_Game.SuspendLayout();
            this.PNL_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Coins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Strength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Health)).BeginInit();
            this.PNL_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Game
            // 
            this.PNL_Game.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PNL_Game.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PNL_Game.Controls.Add(this.PNL_ChildForm);
            this.PNL_Game.Controls.Add(this.Break_Line);
            this.PNL_Game.Controls.Add(this.PNL_Top);
            this.PNL_Game.Controls.Add(this.PNL_Menu);
            this.PNL_Game.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PNL_Game.Location = new System.Drawing.Point(0, 0);
            this.PNL_Game.Name = "PNL_Game";
            this.PNL_Game.Size = new System.Drawing.Size(886, 867);
            this.PNL_Game.TabIndex = 0;
            // 
            // PNL_ChildForm
            // 
            this.PNL_ChildForm.Location = new System.Drawing.Point(0, 48);
            this.PNL_ChildForm.Name = "PNL_ChildForm";
            this.PNL_ChildForm.Size = new System.Drawing.Size(886, 714);
            this.PNL_ChildForm.TabIndex = 4;
            // 
            // Break_Line
            // 
            this.Break_Line.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Break_Line.Location = new System.Drawing.Point(0, 762);
            this.Break_Line.Name = "Break_Line";
            this.Break_Line.Size = new System.Drawing.Size(886, 10);
            this.Break_Line.TabIndex = 3;
            // 
            // PNL_Top
            // 
            this.PNL_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            this.PNL_Top.Controls.Add(this.BTN_Menu);
            this.PNL_Top.Controls.Add(this.LBL_Coins);
            this.PNL_Top.Controls.Add(this.PIC_Coins);
            this.PNL_Top.Controls.Add(this.LBL_Strength);
            this.PNL_Top.Controls.Add(this.PIC_Strength);
            this.PNL_Top.Controls.Add(this.LBL_Health);
            this.PNL_Top.Controls.Add(this.PIC_Health);
            this.PNL_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_Top.Location = new System.Drawing.Point(0, 0);
            this.PNL_Top.Name = "PNL_Top";
            this.PNL_Top.Size = new System.Drawing.Size(886, 48);
            this.PNL_Top.TabIndex = 0;
            // 
            // BTN_Menu
            // 
            this.BTN_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Menu.FlatAppearance.BorderSize = 0;
            this.BTN_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Menu.Image = global::Programming_Internal.Properties.Resources.Menu_Icon;
            this.BTN_Menu.Location = new System.Drawing.Point(0, 0);
            this.BTN_Menu.Name = "BTN_Menu";
            this.BTN_Menu.Size = new System.Drawing.Size(48, 48);
            this.BTN_Menu.TabIndex = 1;
            this.BTN_Menu.UseVisualStyleBackColor = true;
            this.BTN_Menu.Click += new System.EventHandler(this.BTN_Menu_Click);
            // 
            // LBL_Coins
            // 
            this.LBL_Coins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Coins.Location = new System.Drawing.Point(417, 4);
            this.LBL_Coins.Name = "LBL_Coins";
            this.LBL_Coins.Size = new System.Drawing.Size(122, 40);
            this.LBL_Coins.TabIndex = 4;
            this.LBL_Coins.Text = "00000";
            this.LBL_Coins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PIC_Coins
            // 
            this.PIC_Coins.Image = global::Programming_Internal.Properties.Resources.Coin_Icon;
            this.PIC_Coins.Location = new System.Drawing.Point(371, 4);
            this.PIC_Coins.Name = "PIC_Coins";
            this.PIC_Coins.Size = new System.Drawing.Size(40, 40);
            this.PIC_Coins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Coins.TabIndex = 5;
            this.PIC_Coins.TabStop = false;
            // 
            // LBL_Strength
            // 
            this.LBL_Strength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_Strength.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Strength.Location = new System.Drawing.Point(591, 4);
            this.LBL_Strength.Name = "LBL_Strength";
            this.LBL_Strength.Size = new System.Drawing.Size(119, 40);
            this.LBL_Strength.TabIndex = 2;
            this.LBL_Strength.Text = "00000";
            this.LBL_Strength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PIC_Strength
            // 
            this.PIC_Strength.Image = global::Programming_Internal.Properties.Resources.Strength_Icon;
            this.PIC_Strength.Location = new System.Drawing.Point(545, 4);
            this.PIC_Strength.Name = "PIC_Strength";
            this.PIC_Strength.Size = new System.Drawing.Size(40, 40);
            this.PIC_Strength.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Strength.TabIndex = 3;
            this.PIC_Strength.TabStop = false;
            // 
            // LBL_Health
            // 
            this.LBL_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Health.Location = new System.Drawing.Point(762, 4);
            this.LBL_Health.Name = "LBL_Health";
            this.LBL_Health.Size = new System.Drawing.Size(119, 40);
            this.LBL_Health.TabIndex = 1;
            this.LBL_Health.Text = "00000";
            this.LBL_Health.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PIC_Health
            // 
            this.PIC_Health.Image = global::Programming_Internal.Properties.Resources.Health_Icon;
            this.PIC_Health.Location = new System.Drawing.Point(716, 4);
            this.PIC_Health.Name = "PIC_Health";
            this.PIC_Health.Size = new System.Drawing.Size(40, 40);
            this.PIC_Health.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_Health.TabIndex = 1;
            this.PIC_Health.TabStop = false;
            // 
            // PNL_Menu
            // 
            this.PNL_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(45)))), ((int)(((byte)(34)))));
            this.PNL_Menu.Controls.Add(this.BTN_Help);
            this.PNL_Menu.Controls.Add(this.BTN_Quit);
            this.PNL_Menu.Controls.Add(this.BTN_MainMenu);
            this.PNL_Menu.Enabled = false;
            this.PNL_Menu.Location = new System.Drawing.Point(0, 789);
            this.PNL_Menu.Name = "PNL_Menu";
            this.PNL_Menu.Size = new System.Drawing.Size(20, 20);
            this.PNL_Menu.TabIndex = 1;
            this.PNL_Menu.Visible = false;
            // 
            // BTN_Help
            // 
            this.BTN_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Help.FlatAppearance.BorderSize = 0;
            this.BTN_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Help.Location = new System.Drawing.Point(0, 6);
            this.BTN_Help.Name = "BTN_Help";
            this.BTN_Help.Size = new System.Drawing.Size(200, 56);
            this.BTN_Help.TabIndex = 2;
            this.BTN_Help.Text = "Help";
            this.BTN_Help.UseMnemonic = false;
            this.BTN_Help.UseVisualStyleBackColor = true;
            // 
            // BTN_Quit
            // 
            this.BTN_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Quit.FlatAppearance.BorderSize = 0;
            this.BTN_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quit.Location = new System.Drawing.Point(0, 130);
            this.BTN_Quit.Name = "BTN_Quit";
            this.BTN_Quit.Size = new System.Drawing.Size(200, 56);
            this.BTN_Quit.TabIndex = 1;
            this.BTN_Quit.Text = "Save & Quit";
            this.BTN_Quit.UseMnemonic = false;
            this.BTN_Quit.UseVisualStyleBackColor = true;
            // 
            // BTN_MainMenu
            // 
            this.BTN_MainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MainMenu.FlatAppearance.BorderSize = 0;
            this.BTN_MainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_MainMenu.Location = new System.Drawing.Point(0, 68);
            this.BTN_MainMenu.Name = "BTN_MainMenu";
            this.BTN_MainMenu.Size = new System.Drawing.Size(200, 56);
            this.BTN_MainMenu.TabIndex = 0;
            this.BTN_MainMenu.Text = "Main Menu";
            this.BTN_MainMenu.UseMnemonic = false;
            this.BTN_MainMenu.UseVisualStyleBackColor = true;
            // 
            // TMR_ChildFromControl
            // 
            this.TMR_ChildFromControl.Enabled = true;
            this.TMR_ChildFromControl.Tick += new System.EventHandler(this.TMR_ChildFromControl_Tick);
            // 
            // TMR_TopBarDisplay_Refresh
            // 
            this.TMR_TopBarDisplay_Refresh.Enabled = true;
            this.TMR_TopBarDisplay_Refresh.Tick += new System.EventHandler(this.TMR_TopBarDisplay_Refresh_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 861);
            this.Controls.Add(this.PNL_Game);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Song - But It\'s A Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.SizeChanged += new System.EventHandler(this.Game_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Game_Paint);
            this.PNL_Game.ResumeLayout(false);
            this.PNL_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Coins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Strength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Health)).EndInit();
            this.PNL_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Game;
        private System.Windows.Forms.Panel PNL_Top;
        private System.Windows.Forms.PictureBox PIC_Health;
        private System.Windows.Forms.Label LBL_Health;
        private System.Windows.Forms.Label LBL_Coins;
        private System.Windows.Forms.PictureBox PIC_Coins;
        private System.Windows.Forms.Label LBL_Strength;
        private System.Windows.Forms.PictureBox PIC_Strength;
        private System.Windows.Forms.Button BTN_Menu;
        private System.Windows.Forms.Panel PNL_Menu;
        private System.Windows.Forms.Button BTN_MainMenu;
        private System.Windows.Forms.Button BTN_Help;
        private System.Windows.Forms.Button BTN_Quit;
        private System.Windows.Forms.Panel Break_Line;
        private System.Windows.Forms.Panel PNL_ChildForm;
        private System.Windows.Forms.Timer TMR_ChildFromControl;
        private System.Windows.Forms.Timer TMR_TopBarDisplay_Refresh;
    }
}

