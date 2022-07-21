namespace Programming_Internal
{
    partial class Shop
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
            this.PNL_Shop = new System.Windows.Forms.Panel();
            this.PNL_ShopWindow = new System.Windows.Forms.Panel();
            this.PIC_ExitBTN = new System.Windows.Forms.PictureBox();
            this.PNL_PauseCover = new System.Windows.Forms.Panel();
            this.TMR_PausePlayCheck = new System.Windows.Forms.Timer(this.components);
            this.BTN_PurchaseUnit_Window = new System.Windows.Forms.Button();
            this.BTN_UpgradeUnit_Window = new System.Windows.Forms.Button();
            this.BTN_Commander_Window = new System.Windows.Forms.Button();
            this.PNL_Shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ExitBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // PNL_Shop
            // 
            this.PNL_Shop.BackColor = System.Drawing.Color.Transparent;
            this.PNL_Shop.BackgroundImage = global::Programming_Internal.Properties.Resources.Shop_Background;
            this.PNL_Shop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PNL_Shop.Controls.Add(this.BTN_Commander_Window);
            this.PNL_Shop.Controls.Add(this.BTN_UpgradeUnit_Window);
            this.PNL_Shop.Controls.Add(this.BTN_PurchaseUnit_Window);
            this.PNL_Shop.Controls.Add(this.PNL_ShopWindow);
            this.PNL_Shop.Controls.Add(this.PIC_ExitBTN);
            this.PNL_Shop.Location = new System.Drawing.Point(83, 47);
            this.PNL_Shop.Name = "PNL_Shop";
            this.PNL_Shop.Size = new System.Drawing.Size(720, 620);
            this.PNL_Shop.TabIndex = 0;
            // 
            // PNL_ShopWindow
            // 
            this.PNL_ShopWindow.Location = new System.Drawing.Point(0, 136);
            this.PNL_ShopWindow.Name = "PNL_ShopWindow";
            this.PNL_ShopWindow.Size = new System.Drawing.Size(700, 485);
            this.PNL_ShopWindow.TabIndex = 18;
            // 
            // PIC_ExitBTN
            // 
            this.PIC_ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.PIC_ExitBTN.BackgroundImage = global::Programming_Internal.Properties.Resources.Shop_Exit_Button_Icon;
            this.PIC_ExitBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PIC_ExitBTN.Location = new System.Drawing.Point(657, 13);
            this.PIC_ExitBTN.Name = "PIC_ExitBTN";
            this.PIC_ExitBTN.Size = new System.Drawing.Size(50, 50);
            this.PIC_ExitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_ExitBTN.TabIndex = 17;
            this.PIC_ExitBTN.TabStop = false;
            this.PIC_ExitBTN.Click += new System.EventHandler(this.PIC_ExitBTN_Click);
            this.PIC_ExitBTN.MouseLeave += new System.EventHandler(this.PIC_ExitBTN_MouseLeave);
            this.PIC_ExitBTN.MouseHover += new System.EventHandler(this.PIC_ExitBTN_MouseHover);
            // 
            // PNL_PauseCover
            // 
            this.PNL_PauseCover.BackColor = System.Drawing.SystemColors.Control;
            this.PNL_PauseCover.Location = new System.Drawing.Point(12, 680);
            this.PNL_PauseCover.Name = "PNL_PauseCover";
            this.PNL_PauseCover.Size = new System.Drawing.Size(23, 22);
            this.PNL_PauseCover.TabIndex = 16;
            this.PNL_PauseCover.Visible = false;
            // 
            // TMR_PausePlayCheck
            // 
            this.TMR_PausePlayCheck.Enabled = true;
            this.TMR_PausePlayCheck.Tick += new System.EventHandler(this.TMR_PausePlayCheck_Tick);
            // 
            // BTN_PurchaseUnit_Window
            // 
            this.BTN_PurchaseUnit_Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.BTN_PurchaseUnit_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_PurchaseUnit_Window.FlatAppearance.BorderSize = 0;
            this.BTN_PurchaseUnit_Window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PurchaseUnit_Window.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PurchaseUnit_Window.Location = new System.Drawing.Point(3, 90);
            this.BTN_PurchaseUnit_Window.Name = "BTN_PurchaseUnit_Window";
            this.BTN_PurchaseUnit_Window.Size = new System.Drawing.Size(157, 40);
            this.BTN_PurchaseUnit_Window.TabIndex = 0;
            this.BTN_PurchaseUnit_Window.Text = "Unit Shop";
            this.BTN_PurchaseUnit_Window.UseVisualStyleBackColor = false;
            this.BTN_PurchaseUnit_Window.Click += new System.EventHandler(this.BTN_PurchaseUnit_Window_Click);
            // 
            // BTN_UpgradeUnit_Window
            // 
            this.BTN_UpgradeUnit_Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.BTN_UpgradeUnit_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_UpgradeUnit_Window.FlatAppearance.BorderSize = 0;
            this.BTN_UpgradeUnit_Window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_UpgradeUnit_Window.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_UpgradeUnit_Window.Location = new System.Drawing.Point(166, 90);
            this.BTN_UpgradeUnit_Window.Name = "BTN_UpgradeUnit_Window";
            this.BTN_UpgradeUnit_Window.Size = new System.Drawing.Size(210, 40);
            this.BTN_UpgradeUnit_Window.TabIndex = 19;
            this.BTN_UpgradeUnit_Window.Text = "Unit Upgrades";
            this.BTN_UpgradeUnit_Window.UseVisualStyleBackColor = false;
            this.BTN_UpgradeUnit_Window.Click += new System.EventHandler(this.BTN_UpgradeUnit_Window_Click);
            // 
            // BTN_Commander_Window
            // 
            this.BTN_Commander_Window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(85)))), ((int)(((byte)(72)))));
            this.BTN_Commander_Window.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Commander_Window.FlatAppearance.BorderSize = 0;
            this.BTN_Commander_Window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Commander_Window.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Commander_Window.Location = new System.Drawing.Point(382, 90);
            this.BTN_Commander_Window.Name = "BTN_Commander_Window";
            this.BTN_Commander_Window.Size = new System.Drawing.Size(191, 40);
            this.BTN_Commander_Window.TabIndex = 20;
            this.BTN_Commander_Window.Text = "Commander";
            this.BTN_Commander_Window.UseVisualStyleBackColor = false;
            this.BTN_Commander_Window.Click += new System.EventHandler(this.BTN_Commander_Window_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Programming_Internal.Properties.Resources.Background_ArmyCamp;
            this.ClientSize = new System.Drawing.Size(886, 714);
            this.Controls.Add(this.PNL_PauseCover);
            this.Controls.Add(this.PNL_Shop);
            this.DoubleBuffered = true;
            this.Name = "Shop";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shop_FormClosing);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.PNL_Shop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ExitBTN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_Shop;
        private System.Windows.Forms.Panel PNL_PauseCover;
        private System.Windows.Forms.Timer TMR_PausePlayCheck;
        private System.Windows.Forms.PictureBox PIC_ExitBTN;
        private System.Windows.Forms.Panel PNL_ShopWindow;
        private System.Windows.Forms.Button BTN_Commander_Window;
        private System.Windows.Forms.Button BTN_UpgradeUnit_Window;
        private System.Windows.Forms.Button BTN_PurchaseUnit_Window;
    }
}