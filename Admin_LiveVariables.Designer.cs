namespace Programming_Internal
{
    partial class Admin_LiveVariables
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
            this.LIST_Variables = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PNL_List = new System.Windows.Forms.Panel();
            this.PNL_Info = new System.Windows.Forms.Panel();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Toggle_Value = new Programming_Internal.ToggleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.LB_Value = new System.Windows.Forms.ListBox();
            this.TMR_Checker = new System.Windows.Forms.Timer(this.components);
            this.PNL_List.SuspendLayout();
            this.PNL_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // LIST_Variables
            // 
            this.LIST_Variables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.LIST_Variables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LIST_Variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIST_Variables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LIST_Variables.FormattingEnabled = true;
            this.LIST_Variables.ItemHeight = 25;
            this.LIST_Variables.Location = new System.Drawing.Point(10, 40);
            this.LIST_Variables.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.LIST_Variables.Name = "LIST_Variables";
            this.LIST_Variables.Size = new System.Drawing.Size(380, 375);
            this.LIST_Variables.TabIndex = 0;
            this.LIST_Variables.SelectedIndexChanged += new System.EventHandler(this.LIST_Variables_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variable List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_List
            // 
            this.PNL_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_List.Controls.Add(this.LIST_Variables);
            this.PNL_List.Controls.Add(this.label1);
            this.PNL_List.Location = new System.Drawing.Point(20, 20);
            this.PNL_List.Name = "PNL_List";
            this.PNL_List.Size = new System.Drawing.Size(400, 428);
            this.PNL_List.TabIndex = 2;
            // 
            // PNL_Info
            // 
            this.PNL_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_Info.Controls.Add(this.BTN_Refresh);
            this.PNL_Info.Controls.Add(this.BTN_Submit);
            this.PNL_Info.Controls.Add(this.label5);
            this.PNL_Info.Controls.Add(this.lbl_Type);
            this.PNL_Info.Controls.Add(this.label4);
            this.PNL_Info.Controls.Add(this.lbl_Name);
            this.PNL_Info.Controls.Add(this.label3);
            this.PNL_Info.Controls.Add(this.label2);
            this.PNL_Info.Controls.Add(this.Toggle_Value);
            this.PNL_Info.Controls.Add(this.label7);
            this.PNL_Info.Controls.Add(this.label6);
            this.PNL_Info.Controls.Add(this.txt_Value);
            this.PNL_Info.Controls.Add(this.LB_Value);
            this.PNL_Info.Location = new System.Drawing.Point(443, 20);
            this.PNL_Info.Name = "PNL_Info";
            this.PNL_Info.Size = new System.Drawing.Size(278, 428);
            this.PNL_Info.TabIndex = 3;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Value:";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(18, 150);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(75, 20);
            this.lbl_Type.TabIndex = 6;
            this.lbl_Type.Text = "type here";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(16, 84);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(85, 20);
            this.lbl_Name.TabIndex = 4;
            this.lbl_Name.Text = "name here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 57);
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
            // Toggle_Value
            // 
            this.Toggle_Value.AutoSize = true;
            this.Toggle_Value.Location = new System.Drawing.Point(93, 218);
            this.Toggle_Value.MinimumSize = new System.Drawing.Size(45, 22);
            this.Toggle_Value.Name = "Toggle_Value";
            this.Toggle_Value.Size = new System.Drawing.Size(92, 22);
            this.Toggle_Value.TabIndex = 12;
            this.Toggle_Value.Text = "toggleButton1";
            this.Toggle_Value.UseVisualStyleBackColor = true;
            this.Toggle_Value.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "false";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "true";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // txt_Value
            // 
            this.txt_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Value.Location = new System.Drawing.Point(22, 217);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(236, 26);
            this.txt_Value.TabIndex = 8;
            this.txt_Value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Value_KeyPress);
            // 
            // LB_Value
            // 
            this.LB_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Value.FormattingEnabled = true;
            this.LB_Value.ItemHeight = 20;
            this.LB_Value.Location = new System.Drawing.Point(20, 217);
            this.LB_Value.Name = "LB_Value";
            this.LB_Value.Size = new System.Drawing.Size(238, 144);
            this.LB_Value.TabIndex = 13;
            this.LB_Value.Visible = false;
            // 
            // TMR_Checker
            // 
            this.TMR_Checker.Enabled = true;
            this.TMR_Checker.Tick += new System.EventHandler(this.TMR_Checker_Tick);
            // 
            // Admin_LiveVariables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 468);
            this.Controls.Add(this.PNL_Info);
            this.Controls.Add(this.PNL_List);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_LiveVariables";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Admin_LiveVariables";
            this.Load += new System.EventHandler(this.Admin_LiveVariables_Load);
            this.PNL_List.ResumeLayout(false);
            this.PNL_Info.ResumeLayout(false);
            this.PNL_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LIST_Variables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PNL_List;
        private System.Windows.Forms.Panel PNL_Info;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ToggleButton Toggle_Value;
        private System.Windows.Forms.ListBox LB_Value;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.Timer TMR_Checker;
    }
}