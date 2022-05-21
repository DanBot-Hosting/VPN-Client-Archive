namespace DbhVpnClient.App
{
    partial class MainForm
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_menu_leftTag = new System.Windows.Forms.Panel();
            this.button_menu_Account = new System.Windows.Forms.Button();
            this.button_menu_Dashboard = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.label_CurrentIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lable_ConnectedTo = new System.Windows.Forms.Label();
            this.button_Dissconnect = new System.Windows.Forms.Button();
            this.panel_Account = new System.Windows.Forms.Panel();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Status.SuspendLayout();
            this.panel_Account.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.Controls.Add(this.panel_menu_leftTag);
            this.panel_menu.Controls.Add(this.button_menu_Account);
            this.panel_menu.Controls.Add(this.button_menu_Dashboard);
            this.panel_menu.Location = new System.Drawing.Point(4, 150);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(238, 457);
            this.panel_menu.TabIndex = 1;
            // 
            // panel_menu_leftTag
            // 
            this.panel_menu_leftTag.BackColor = System.Drawing.Color.Cyan;
            this.panel_menu_leftTag.Location = new System.Drawing.Point(228, 0);
            this.panel_menu_leftTag.Name = "panel_menu_leftTag";
            this.panel_menu_leftTag.Size = new System.Drawing.Size(10, 100);
            this.panel_menu_leftTag.TabIndex = 4;
            // 
            // button_menu_Account
            // 
            this.button_menu_Account.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_menu_Account.FlatAppearance.BorderSize = 0;
            this.button_menu_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_Account.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_menu_Account.ForeColor = System.Drawing.Color.White;
            this.button_menu_Account.Location = new System.Drawing.Point(0, 357);
            this.button_menu_Account.Name = "button_menu_Account";
            this.button_menu_Account.Size = new System.Drawing.Size(235, 100);
            this.button_menu_Account.TabIndex = 5;
            this.button_menu_Account.Text = "Account";
            this.button_menu_Account.UseVisualStyleBackColor = true;
            this.button_menu_Account.Click += new System.EventHandler(this.button_menu_Account_Click);
            // 
            // button_menu_Dashboard
            // 
            this.button_menu_Dashboard.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button_menu_Dashboard.FlatAppearance.BorderSize = 0;
            this.button_menu_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu_Dashboard.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_menu_Dashboard.ForeColor = System.Drawing.Color.White;
            this.button_menu_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.button_menu_Dashboard.Name = "button_menu_Dashboard";
            this.button_menu_Dashboard.Size = new System.Drawing.Size(238, 100);
            this.button_menu_Dashboard.TabIndex = 4;
            this.button_menu_Dashboard.Text = "Dashboard";
            this.button_menu_Dashboard.UseVisualStyleBackColor = true;
            this.button_menu_Dashboard.Click += new System.EventHandler(this.button_menu_Dashboard_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.Controls.Add(this.label3);
            this.panel_Logo.Location = new System.Drawing.Point(3, 3);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(239, 145);
            this.panel_Logo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "DBH VPN";
            // 
            // panel_Status
            // 
            this.panel_Status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.panel_Status.Controls.Add(this.label_CurrentIP);
            this.panel_Status.Controls.Add(this.label2);
            this.panel_Status.Controls.Add(this.label1);
            this.panel_Status.Controls.Add(this.lable_ConnectedTo);
            this.panel_Status.Controls.Add(this.button_Dissconnect);
            this.panel_Status.Location = new System.Drawing.Point(245, 512);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(828, 95);
            this.panel_Status.TabIndex = 3;
            // 
            // label_CurrentIP
            // 
            this.label_CurrentIP.AutoSize = true;
            this.label_CurrentIP.Location = new System.Drawing.Point(176, 52);
            this.label_CurrentIP.Name = "label_CurrentIP";
            this.label_CurrentIP.Size = new System.Drawing.Size(69, 23);
            this.label_CurrentIP.TabIndex = 4;
            this.label_CurrentIP.Text = "0.0.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current IP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connected To:";
            // 
            // lable_ConnectedTo
            // 
            this.lable_ConnectedTo.AutoSize = true;
            this.lable_ConnectedTo.Location = new System.Drawing.Point(176, 10);
            this.lable_ConnectedTo.Name = "lable_ConnectedTo";
            this.lable_ConnectedTo.Size = new System.Drawing.Size(154, 23);
            this.lable_ConnectedTo.TabIndex = 1;
            this.lable_ConnectedTo.Text = "Dissconnected";
            // 
            // button_Dissconnect
            // 
            this.button_Dissconnect.Location = new System.Drawing.Point(677, 22);
            this.button_Dissconnect.Name = "button_Dissconnect";
            this.button_Dissconnect.Size = new System.Drawing.Size(139, 44);
            this.button_Dissconnect.TabIndex = 0;
            this.button_Dissconnect.Text = "Dissconnect";
            this.button_Dissconnect.UseVisualStyleBackColor = true;
            // 
            // panel_Account
            // 
            this.panel_Account.Controls.Add(this.button_Login);
            this.panel_Account.Location = new System.Drawing.Point(244, 6);
            this.panel_Account.Name = "panel_Account";
            this.panel_Account.Size = new System.Drawing.Size(829, 505);
            this.panel_Account.TabIndex = 4;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(309, 181);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(207, 109);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login / Ragister";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1073, 610);
            this.Controls.Add(this.panel_Account);
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.panel_Logo);
            this.Controls.Add(this.panel_menu);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.panel_Account.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_menu;
        private Panel panel_Logo;
        private Button button_menu_Account;
        private Button button_menu_Dashboard;
        private Panel panel_Status;
        private Panel panel_menu_leftTag;
        private Label lable_ConnectedTo;
        private Button button_Dissconnect;
        private Label label_CurrentIP;
        private Label label2;
        private Label label1;
        private Panel panel_Account;
        private Button button_Login;
        private Label label3;
    }
}