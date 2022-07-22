namespace Programming_Internal
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.PNL_Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.BTN_Users = new System.Windows.Forms.Button();
            this.BTN_UnitSettings = new System.Windows.Forms.Button();
            this.BTN_LiveVariables = new System.Windows.Forms.Button();
            this.BTN_Home = new System.Windows.Forms.Button();
            this.PNL_MenuTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.PNL_TopBar = new System.Windows.Forms.Panel();
            this.PNL_Body = new System.Windows.Forms.Panel();
            this.dragControl1 = new Programming_Internal.DragControl(this.components);
            this.TMR_Checker = new System.Windows.Forms.Timer(this.components);
            this.PNL_Menu.SuspendLayout();
            this.PNL_MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PNL_TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Menu
            // 
            this.PNL_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.PNL_Menu.Controls.Add(this.button1);
            this.PNL_Menu.Controls.Add(this.BTN_Exit);
            this.PNL_Menu.Controls.Add(this.BTN_Users);
            this.PNL_Menu.Controls.Add(this.BTN_UnitSettings);
            this.PNL_Menu.Controls.Add(this.BTN_LiveVariables);
            this.PNL_Menu.Controls.Add(this.BTN_Home);
            this.PNL_Menu.Controls.Add(this.PNL_MenuTop);
            this.PNL_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PNL_Menu.Location = new System.Drawing.Point(0, 0);
            this.PNL_Menu.Name = "PNL_Menu";
            this.PNL_Menu.Size = new System.Drawing.Size(186, 538);
            this.PNL_Menu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(0, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Other";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BTN_Exit.FlatAppearance.BorderSize = 0;
            this.BTN_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Exit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTN_Exit.Location = new System.Drawing.Point(0, 496);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(186, 42);
            this.BTN_Exit.TabIndex = 7;
            this.BTN_Exit.Text = "Exit Admin";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            this.BTN_Exit.Click += new System.EventHandler(this.BTN_Exit_Click);
            // 
            // BTN_Users
            // 
            this.BTN_Users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Users.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Users.FlatAppearance.BorderSize = 0;
            this.BTN_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Users.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Users.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTN_Users.Location = new System.Drawing.Point(0, 270);
            this.BTN_Users.Name = "BTN_Users";
            this.BTN_Users.Size = new System.Drawing.Size(186, 42);
            this.BTN_Users.TabIndex = 5;
            this.BTN_Users.Text = "Users";
            this.BTN_Users.UseVisualStyleBackColor = true;
            this.BTN_Users.Click += new System.EventHandler(this.BTN_Users_Click);
            // 
            // BTN_UnitSettings
            // 
            this.BTN_UnitSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UnitSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_UnitSettings.FlatAppearance.BorderSize = 0;
            this.BTN_UnitSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UnitSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UnitSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTN_UnitSettings.Location = new System.Drawing.Point(0, 228);
            this.BTN_UnitSettings.Name = "BTN_UnitSettings";
            this.BTN_UnitSettings.Size = new System.Drawing.Size(186, 42);
            this.BTN_UnitSettings.TabIndex = 4;
            this.BTN_UnitSettings.Text = "Unit Settings";
            this.BTN_UnitSettings.UseVisualStyleBackColor = true;
            this.BTN_UnitSettings.Click += new System.EventHandler(this.BTN_UnitSettings_Click);
            // 
            // BTN_LiveVariables
            // 
            this.BTN_LiveVariables.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_LiveVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_LiveVariables.FlatAppearance.BorderSize = 0;
            this.BTN_LiveVariables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LiveVariables.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_LiveVariables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTN_LiveVariables.Location = new System.Drawing.Point(0, 186);
            this.BTN_LiveVariables.Name = "BTN_LiveVariables";
            this.BTN_LiveVariables.Size = new System.Drawing.Size(186, 42);
            this.BTN_LiveVariables.TabIndex = 3;
            this.BTN_LiveVariables.Text = "Live Variables";
            this.BTN_LiveVariables.UseVisualStyleBackColor = true;
            this.BTN_LiveVariables.Click += new System.EventHandler(this.BTN_LiveVariables_Click);
            // 
            // BTN_Home
            // 
            this.BTN_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Home.FlatAppearance.BorderSize = 0;
            this.BTN_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Home.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.BTN_Home.Location = new System.Drawing.Point(0, 144);
            this.BTN_Home.Name = "BTN_Home";
            this.BTN_Home.Size = new System.Drawing.Size(186, 42);
            this.BTN_Home.TabIndex = 2;
            this.BTN_Home.Text = "Home";
            this.BTN_Home.UseVisualStyleBackColor = true;
            this.BTN_Home.Click += new System.EventHandler(this.BTN_Home_Click);
            // 
            // PNL_MenuTop
            // 
            this.PNL_MenuTop.Controls.Add(this.label1);
            this.PNL_MenuTop.Controls.Add(this.pictureBox1);
            this.PNL_MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MenuTop.Location = new System.Drawing.Point(0, 0);
            this.PNL_MenuTop.Name = "PNL_MenuTop";
            this.PNL_MenuTop.Size = new System.Drawing.Size(186, 144);
            this.PNL_MenuTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Duck Game";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_Title.Location = new System.Drawing.Point(20, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(93, 32);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Home";
            // 
            // PNL_TopBar
            // 
            this.PNL_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.PNL_TopBar.Controls.Add(this.lbl_Title);
            this.PNL_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TopBar.Location = new System.Drawing.Point(186, 0);
            this.PNL_TopBar.Name = "PNL_TopBar";
            this.PNL_TopBar.Size = new System.Drawing.Size(749, 70);
            this.PNL_TopBar.TabIndex = 4;
            // 
            // PNL_Body
            // 
            this.PNL_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Body.Location = new System.Drawing.Point(186, 70);
            this.PNL_Body.Name = "PNL_Body";
            this.PNL_Body.Size = new System.Drawing.Size(749, 468);
            this.PNL_Body.TabIndex = 5;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.PNL_TopBar;
            // 
            // TMR_Checker
            // 
            this.TMR_Checker.Enabled = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.PNL_Body);
            this.Controls.Add(this.PNL_TopBar);
            this.Controls.Add(this.PNL_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.PNL_Menu.ResumeLayout(false);
            this.PNL_MenuTop.ResumeLayout(false);
            this.PNL_MenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PNL_TopBar.ResumeLayout(false);
            this.PNL_TopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Menu;
        private System.Windows.Forms.Button BTN_Users;
        private System.Windows.Forms.Button BTN_UnitSettings;
        private System.Windows.Forms.Button BTN_LiveVariables;
        private System.Windows.Forms.Button BTN_Home;
        private System.Windows.Forms.Panel PNL_MenuTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Button button1;
        private DragControl dragControl1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel PNL_Body;
        private System.Windows.Forms.Panel PNL_TopBar;
        private System.Windows.Forms.Timer TMR_Checker;
    }
}