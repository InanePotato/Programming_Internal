namespace Programming_Internal
{
    partial class Admin_Home
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
            this.PNL_Settings = new System.Windows.Forms.Panel();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.toggle_Snap = new Programming_Internal.ToggleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PIC_Duck = new System.Windows.Forms.PictureBox();
            this.TMR_Checker = new System.Windows.Forms.Timer(this.components);
            this.PNL_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Duck)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Settings
            // 
            this.PNL_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PNL_Settings.Controls.Add(this.BTN_Submit);
            this.PNL_Settings.Controls.Add(this.toggle_Snap);
            this.PNL_Settings.Controls.Add(this.label1);
            this.PNL_Settings.Controls.Add(this.label4);
            this.PNL_Settings.Controls.Add(this.label3);
            this.PNL_Settings.Controls.Add(this.label2);
            this.PNL_Settings.Location = new System.Drawing.Point(447, 20);
            this.PNL_Settings.Name = "PNL_Settings";
            this.PNL_Settings.Size = new System.Drawing.Size(278, 428);
            this.PNL_Settings.TabIndex = 0;
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Submit.FlatAppearance.BorderSize = 0;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Submit.Location = new System.Drawing.Point(24, 360);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(233, 48);
            this.BTN_Submit.TabIndex = 9;
            this.BTN_Submit.Text = "Submit";
            this.BTN_Submit.UseVisualStyleBackColor = true;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // toggle_Snap
            // 
            this.toggle_Snap.AutoSize = true;
            this.toggle_Snap.Location = new System.Drawing.Point(54, 92);
            this.toggle_Snap.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggle_Snap.Name = "toggle_Snap";
            this.toggle_Snap.Size = new System.Drawing.Size(92, 22);
            this.toggle_Snap.TabIndex = 8;
            this.toggle_Snap.Text = "toggleButton1";
            this.toggle_Snap.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "on";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Snap To Side";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PIC_Duck
            // 
            this.PIC_Duck.Image = global::Programming_Internal.Properties.Resources.Duck;
            this.PIC_Duck.Location = new System.Drawing.Point(138, 131);
            this.PIC_Duck.Name = "PIC_Duck";
            this.PIC_Duck.Size = new System.Drawing.Size(200, 200);
            this.PIC_Duck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PIC_Duck.TabIndex = 1;
            this.PIC_Duck.TabStop = false;
            // 
            // TMR_Checker
            // 
            this.TMR_Checker.Enabled = true;
            this.TMR_Checker.Tick += new System.EventHandler(this.TMR_Checker_Tick);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(749, 468);
            this.Controls.Add(this.PIC_Duck);
            this.Controls.Add(this.PNL_Settings);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Admin_Home";
            this.Load += new System.EventHandler(this.Admin_Home_Load);
            this.PNL_Settings.ResumeLayout(false);
            this.PNL_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_Duck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Settings;
        private System.Windows.Forms.PictureBox PIC_Duck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ToggleButton toggle_Snap;
        private System.Windows.Forms.Timer TMR_Checker;
        private System.Windows.Forms.Button BTN_Submit;
    }
}