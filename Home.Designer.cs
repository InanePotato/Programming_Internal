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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.BTN_Play = new System.Windows.Forms.Button();
            this.PIC_Title = new System.Windows.Forms.PictureBox();
            this.TMR_Controls = new System.Windows.Forms.Timer(this.components);
            this.BTN_Save1 = new System.Windows.Forms.Button();
            this.BTN_Save2 = new System.Windows.Forms.Button();
            this.BTN_Save3 = new System.Windows.Forms.Button();
            this.BTN_Save4 = new System.Windows.Forms.Button();
            this.TXT_CreateSaveName = new System.Windows.Forms.TextBox();
            this.LBL_CreateSave = new System.Windows.Forms.Label();
            this.BTN_BackToSelect = new System.Windows.Forms.Button();
            this.BTN_CreateNewSave = new System.Windows.Forms.Button();
            this.TXT_AdminPassword = new System.Windows.Forms.TextBox();
            this.CBTN_DeleteSelectedSave = new Programming_Internal.CircleButton();
            this.CBTN_AdminAccess = new Programming_Internal.CircleButton();
            this.CBTN_Help = new Programming_Internal.CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Play
            // 
            this.BTN_Play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Play.Location = new System.Drawing.Point(684, 434);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(200, 60);
            this.BTN_Play.TabIndex = 4;
            this.BTN_Play.Text = "Play";
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
            // TMR_Controls
            // 
            this.TMR_Controls.Enabled = true;
            this.TMR_Controls.Tick += new System.EventHandler(this.TMR_Controls_Tick);
            // 
            // BTN_Save1
            // 
            this.BTN_Save1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Save1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Save1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save1.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Save1.Location = new System.Drawing.Point(590, 192);
            this.BTN_Save1.Name = "BTN_Save1";
            this.BTN_Save1.Size = new System.Drawing.Size(387, 50);
            this.BTN_Save1.TabIndex = 5;
            this.BTN_Save1.Text = "[ New Save ]";
            this.BTN_Save1.UseVisualStyleBackColor = false;
            this.BTN_Save1.Click += new System.EventHandler(this.BTN_Save1_Click);
            // 
            // BTN_Save2
            // 
            this.BTN_Save2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Save2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Save2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save2.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Save2.Location = new System.Drawing.Point(590, 248);
            this.BTN_Save2.Name = "BTN_Save2";
            this.BTN_Save2.Size = new System.Drawing.Size(387, 50);
            this.BTN_Save2.TabIndex = 6;
            this.BTN_Save2.Text = "[ New Save ]";
            this.BTN_Save2.UseVisualStyleBackColor = false;
            this.BTN_Save2.Click += new System.EventHandler(this.BTN_Save2_Click);
            // 
            // BTN_Save3
            // 
            this.BTN_Save3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Save3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Save3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save3.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Save3.Location = new System.Drawing.Point(590, 304);
            this.BTN_Save3.Name = "BTN_Save3";
            this.BTN_Save3.Size = new System.Drawing.Size(387, 50);
            this.BTN_Save3.TabIndex = 7;
            this.BTN_Save3.Text = "[ New Save ]";
            this.BTN_Save3.UseVisualStyleBackColor = false;
            this.BTN_Save3.Click += new System.EventHandler(this.BTN_Save3_Click);
            // 
            // BTN_Save4
            // 
            this.BTN_Save4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_Save4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BTN_Save4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Save4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Save4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Save4.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Save4.Location = new System.Drawing.Point(590, 360);
            this.BTN_Save4.Name = "BTN_Save4";
            this.BTN_Save4.Size = new System.Drawing.Size(387, 50);
            this.BTN_Save4.TabIndex = 8;
            this.BTN_Save4.Text = "[ New Save ]";
            this.BTN_Save4.UseVisualStyleBackColor = false;
            this.BTN_Save4.Click += new System.EventHandler(this.BTN_Save4_Click);
            // 
            // TXT_CreateSaveName
            // 
            this.TXT_CreateSaveName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TXT_CreateSaveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_CreateSaveName.Location = new System.Drawing.Point(180, 284);
            this.TXT_CreateSaveName.Name = "TXT_CreateSaveName";
            this.TXT_CreateSaveName.Size = new System.Drawing.Size(387, 38);
            this.TXT_CreateSaveName.TabIndex = 9;
            this.TXT_CreateSaveName.Visible = false;
            this.TXT_CreateSaveName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_CreateSaveName_KeyPress);
            // 
            // LBL_CreateSave
            // 
            this.LBL_CreateSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_CreateSave.AutoSize = true;
            this.LBL_CreateSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CreateSave.Location = new System.Drawing.Point(174, 248);
            this.LBL_CreateSave.Name = "LBL_CreateSave";
            this.LBL_CreateSave.Size = new System.Drawing.Size(247, 33);
            this.LBL_CreateSave.TabIndex = 10;
            this.LBL_CreateSave.Text = "Input Save Name:";
            this.LBL_CreateSave.Visible = false;
            // 
            // BTN_BackToSelect
            // 
            this.BTN_BackToSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_BackToSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_BackToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BackToSelect.Location = new System.Drawing.Point(180, 352);
            this.BTN_BackToSelect.Name = "BTN_BackToSelect";
            this.BTN_BackToSelect.Size = new System.Drawing.Size(190, 60);
            this.BTN_BackToSelect.TabIndex = 11;
            this.BTN_BackToSelect.Text = "Back";
            this.BTN_BackToSelect.UseVisualStyleBackColor = true;
            this.BTN_BackToSelect.Visible = false;
            this.BTN_BackToSelect.Click += new System.EventHandler(this.BTN_BackToSelect_Click);
            // 
            // BTN_CreateNewSave
            // 
            this.BTN_CreateNewSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BTN_CreateNewSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CreateNewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CreateNewSave.Location = new System.Drawing.Point(377, 352);
            this.BTN_CreateNewSave.Name = "BTN_CreateNewSave";
            this.BTN_CreateNewSave.Size = new System.Drawing.Size(190, 60);
            this.BTN_CreateNewSave.TabIndex = 12;
            this.BTN_CreateNewSave.Text = "Create";
            this.BTN_CreateNewSave.UseVisualStyleBackColor = true;
            this.BTN_CreateNewSave.Visible = false;
            this.BTN_CreateNewSave.Click += new System.EventHandler(this.BTN_CreateNewSave_Click);
            // 
            // TXT_AdminPassword
            // 
            this.TXT_AdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_AdminPassword.Location = new System.Drawing.Point(12, 417);
            this.TXT_AdminPassword.Name = "TXT_AdminPassword";
            this.TXT_AdminPassword.Size = new System.Drawing.Size(140, 26);
            this.TXT_AdminPassword.TabIndex = 16;
            this.TXT_AdminPassword.Visible = false;
            this.TXT_AdminPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_AdminPassword_KeyPress);
            // 
            // CBTN_DeleteSelectedSave
            // 
            this.CBTN_DeleteSelectedSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBTN_DeleteSelectedSave.BackColor = System.Drawing.Color.Red;
            this.CBTN_DeleteSelectedSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CBTN_DeleteSelectedSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTN_DeleteSelectedSave.FlatAppearance.BorderSize = 0;
            this.CBTN_DeleteSelectedSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTN_DeleteSelectedSave.Image = ((System.Drawing.Image)(resources.GetObject("CBTN_DeleteSelectedSave.Image")));
            this.CBTN_DeleteSelectedSave.Location = new System.Drawing.Point(68, 449);
            this.CBTN_DeleteSelectedSave.Name = "CBTN_DeleteSelectedSave";
            this.CBTN_DeleteSelectedSave.Size = new System.Drawing.Size(50, 50);
            this.CBTN_DeleteSelectedSave.TabIndex = 15;
            this.CBTN_DeleteSelectedSave.UseVisualStyleBackColor = false;
            this.CBTN_DeleteSelectedSave.Visible = false;
            this.CBTN_DeleteSelectedSave.Click += new System.EventHandler(this.CBTN_DeleteSelectedSave_Click);
            // 
            // CBTN_AdminAccess
            // 
            this.CBTN_AdminAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBTN_AdminAccess.BackColor = System.Drawing.Color.Silver;
            this.CBTN_AdminAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTN_AdminAccess.FlatAppearance.BorderSize = 0;
            this.CBTN_AdminAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTN_AdminAccess.Image = global::Programming_Internal.Properties.Resources.KeyIcon;
            this.CBTN_AdminAccess.Location = new System.Drawing.Point(12, 449);
            this.CBTN_AdminAccess.Name = "CBTN_AdminAccess";
            this.CBTN_AdminAccess.Size = new System.Drawing.Size(50, 50);
            this.CBTN_AdminAccess.TabIndex = 14;
            this.CBTN_AdminAccess.UseVisualStyleBackColor = false;
            this.CBTN_AdminAccess.Click += new System.EventHandler(this.CBTN_AdminAccess_Click);
            // 
            // CBTN_Help
            // 
            this.CBTN_Help.BackColor = System.Drawing.Color.Silver;
            this.CBTN_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTN_Help.FlatAppearance.BorderSize = 0;
            this.CBTN_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBTN_Help.Image = global::Programming_Internal.Properties.Resources.HelpIcon;
            this.CBTN_Help.Location = new System.Drawing.Point(12, 12);
            this.CBTN_Help.Name = "CBTN_Help";
            this.CBTN_Help.Size = new System.Drawing.Size(50, 50);
            this.CBTN_Help.TabIndex = 13;
            this.CBTN_Help.UseVisualStyleBackColor = false;
            this.CBTN_Help.Click += new System.EventHandler(this.CBTN_Help_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.TXT_AdminPassword);
            this.Controls.Add(this.CBTN_DeleteSelectedSave);
            this.Controls.Add(this.CBTN_AdminAccess);
            this.Controls.Add(this.CBTN_Help);
            this.Controls.Add(this.BTN_CreateNewSave);
            this.Controls.Add(this.BTN_BackToSelect);
            this.Controls.Add(this.LBL_CreateSave);
            this.Controls.Add(this.TXT_CreateSaveName);
            this.Controls.Add(this.BTN_Save4);
            this.Controls.Add(this.BTN_Save3);
            this.Controls.Add(this.BTN_Save2);
            this.Controls.Add(this.BTN_Save1);
            this.Controls.Add(this.PIC_Title);
            this.Controls.Add(this.BTN_Play);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Duck Game";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.PictureBox PIC_Title;
        private System.Windows.Forms.Timer TMR_Controls;
        private System.Windows.Forms.Button BTN_Save1;
        private System.Windows.Forms.Button BTN_Save2;
        private System.Windows.Forms.Button BTN_Save3;
        private System.Windows.Forms.Button BTN_Save4;
        private System.Windows.Forms.TextBox TXT_CreateSaveName;
        private System.Windows.Forms.Label LBL_CreateSave;
        private System.Windows.Forms.Button BTN_BackToSelect;
        private System.Windows.Forms.Button BTN_CreateNewSave;
        private CircleButton CBTN_Help;
        private CircleButton CBTN_AdminAccess;
        private CircleButton CBTN_DeleteSelectedSave;
        private System.Windows.Forms.TextBox TXT_AdminPassword;
    }
}