namespace Programming_Internal
{
    partial class Admin_UnitSettings
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
            this.PNL_Info = new System.Windows.Forms.Panel();
            this.lbl_Abilities = new System.Windows.Forms.Label();
            this.CB_Range = new System.Windows.Forms.ComboBox();
            this.txt_Cost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_AttackSpeed = new System.Windows.Forms.TextBox();
            this.txt_Health = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Damage = new System.Windows.Forms.TextBox();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PNL_List = new System.Windows.Forms.Panel();
            this.LIST_UnitSettngs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TMR_Checker = new System.Windows.Forms.Timer(this.components);
            this.PNL_Info.SuspendLayout();
            this.PNL_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Info
            // 
            this.PNL_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_Info.Controls.Add(this.lbl_Abilities);
            this.PNL_Info.Controls.Add(this.CB_Range);
            this.PNL_Info.Controls.Add(this.txt_Cost);
            this.PNL_Info.Controls.Add(this.label9);
            this.PNL_Info.Controls.Add(this.label8);
            this.PNL_Info.Controls.Add(this.label7);
            this.PNL_Info.Controls.Add(this.txt_AttackSpeed);
            this.PNL_Info.Controls.Add(this.txt_Health);
            this.PNL_Info.Controls.Add(this.label6);
            this.PNL_Info.Controls.Add(this.label5);
            this.PNL_Info.Controls.Add(this.txt_Damage);
            this.PNL_Info.Controls.Add(this.BTN_Refresh);
            this.PNL_Info.Controls.Add(this.BTN_Submit);
            this.PNL_Info.Controls.Add(this.label4);
            this.PNL_Info.Controls.Add(this.lbl_Name);
            this.PNL_Info.Controls.Add(this.label3);
            this.PNL_Info.Controls.Add(this.label2);
            this.PNL_Info.Location = new System.Drawing.Point(447, 20);
            this.PNL_Info.Name = "PNL_Info";
            this.PNL_Info.Size = new System.Drawing.Size(278, 428);
            this.PNL_Info.TabIndex = 5;
            // 
            // lbl_Abilities
            // 
            this.lbl_Abilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Abilities.Location = new System.Drawing.Point(12, 259);
            this.lbl_Abilities.Name = "lbl_Abilities";
            this.lbl_Abilities.Size = new System.Drawing.Size(245, 82);
            this.lbl_Abilities.TabIndex = 24;
            this.lbl_Abilities.Text = "ability1\r\nability2\r\nability3";
            // 
            // CB_Range
            // 
            this.CB_Range.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Range.FormattingEnabled = true;
            this.CB_Range.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.CB_Range.Location = new System.Drawing.Point(108, 172);
            this.CB_Range.Name = "CB_Range";
            this.CB_Range.Size = new System.Drawing.Size(149, 28);
            this.CB_Range.TabIndex = 23;
            // 
            // txt_Cost
            // 
            this.txt_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cost.Location = new System.Drawing.Point(108, 205);
            this.txt_Cost.Name = "txt_Cost";
            this.txt_Cost.Size = new System.Drawing.Size(149, 26);
            this.txt_Cost.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Abilities:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Range:";
            // 
            // txt_AttackSpeed
            // 
            this.txt_AttackSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AttackSpeed.Location = new System.Drawing.Point(108, 142);
            this.txt_AttackSpeed.Name = "txt_AttackSpeed";
            this.txt_AttackSpeed.Size = new System.Drawing.Size(149, 26);
            this.txt_AttackSpeed.TabIndex = 18;
            // 
            // txt_Health
            // 
            this.txt_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Health.Location = new System.Drawing.Point(108, 112);
            this.txt_Health.Name = "txt_Health";
            this.txt_Health.Size = new System.Drawing.Size(149, 26);
            this.txt_Health.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Atk Spd:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Health:";
            // 
            // txt_Damage
            // 
            this.txt_Damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Damage.Location = new System.Drawing.Point(108, 82);
            this.txt_Damage.Name = "txt_Damage";
            this.txt_Damage.Size = new System.Drawing.Size(149, 26);
            this.txt_Damage.TabIndex = 16;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Enabled = false;
            this.BTN_Refresh.FlatAppearance.BorderSize = 0;
            this.BTN_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Refresh.Location = new System.Drawing.Point(138, 375);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(119, 39);
            this.BTN_Refresh.TabIndex = 15;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            this.BTN_Refresh.Click += new System.EventHandler(this.BTN_Refresh_Click);
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Enabled = false;
            this.BTN_Submit.FlatAppearance.BorderSize = 0;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.Location = new System.Drawing.Point(19, 375);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(119, 39);
            this.BTN_Submit.TabIndex = 14;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Damage:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(108, 51);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(105, 25);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "name here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Variable Details";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_List
            // 
            this.PNL_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_List.Controls.Add(this.LIST_UnitSettngs);
            this.PNL_List.Controls.Add(this.label1);
            this.PNL_List.Location = new System.Drawing.Point(24, 20);
            this.PNL_List.Name = "PNL_List";
            this.PNL_List.Size = new System.Drawing.Size(400, 428);
            this.PNL_List.TabIndex = 4;
            // 
            // LIST_UnitSettngs
            // 
            this.LIST_UnitSettngs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.LIST_UnitSettngs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LIST_UnitSettngs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_UnitSettngs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LIST_UnitSettngs.FormattingEnabled = true;
            this.LIST_UnitSettngs.ItemHeight = 25;
            this.LIST_UnitSettngs.Location = new System.Drawing.Point(10, 40);
            this.LIST_UnitSettngs.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LIST_UnitSettngs.Name = "LIST_UnitSettngs";
            this.LIST_UnitSettngs.Size = new System.Drawing.Size(380, 375);
            this.LIST_UnitSettngs.TabIndex = 0;
            this.LIST_UnitSettngs.SelectedIndexChanged += new System.EventHandler(this.LIST_UnitSettngs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TMR_Checker
            // 
            this.TMR_Checker.Enabled = true;
            this.TMR_Checker.Tick += new System.EventHandler(this.TMR_Checker_Tick);
            // 
            // Admin_UnitSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 468);
            this.Controls.Add(this.PNL_Info);
            this.Controls.Add(this.PNL_List);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_UnitSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Admin_UnitSettings";
            this.Load += new System.EventHandler(this.Admin_UnitSettings_Load);
            this.PNL_Info.ResumeLayout(false);
            this.PNL_Info.PerformLayout();
            this.PNL_List.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Info;
        private System.Windows.Forms.TextBox txt_Health;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Damage;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PNL_List;
        private System.Windows.Forms.ListBox LIST_UnitSettngs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_AttackSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_Range;
        private System.Windows.Forms.TextBox txt_Cost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Abilities;
        private System.Windows.Forms.Timer TMR_Checker;
    }
}