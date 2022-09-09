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
            this.PNL_Battle = new System.Windows.Forms.Panel();
            this.TMR_Battle = new System.Windows.Forms.Timer(this.components);
            this.TMR_Controls = new System.Windows.Forms.Timer(this.components);
            this.TMR_Attack = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.PNL_Battleground.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_Battleground
            // 
            this.PNL_Battleground.BackgroundImage = global::Programming_Internal.Properties.Resources.Battleground_Background2;
            this.PNL_Battleground.Controls.Add(this.button1);
            this.PNL_Battleground.Controls.Add(this.PNL_Battle);
            this.PNL_Battleground.Location = new System.Drawing.Point(0, 0);
            this.PNL_Battleground.Name = "PNL_Battleground";
            this.PNL_Battleground.Size = new System.Drawing.Size(886, 714);
            this.PNL_Battleground.TabIndex = 0;
            // 
            // PNL_Battle
            // 
            this.PNL_Battle.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Battle.Location = new System.Drawing.Point(0, 303);
            this.PNL_Battle.Name = "PNL_Battle";
            this.PNL_Battle.Size = new System.Drawing.Size(886, 220);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Battleground;
        private System.Windows.Forms.Panel PNL_Battle;
        private System.Windows.Forms.Timer TMR_Battle;
        private System.Windows.Forms.Timer TMR_Controls;
        private System.Windows.Forms.Timer TMR_Attack;
        private System.Windows.Forms.Button button1;
    }
}