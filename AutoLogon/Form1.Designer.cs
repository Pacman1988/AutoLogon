namespace AutoLogon
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_set = new System.Windows.Forms.Button();
            this.cb_autologon = new System.Windows.Forms.CheckBox();
            this.lb_autologon = new System.Windows.Forms.Label();
            this.lb_domainname = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tf_domainname = new System.Windows.Forms.TextBox();
            this.tf_username = new System.Windows.Forms.TextBox();
            this.tf_password = new System.Windows.Forms.TextBox();
            this.tf_passwordcheck = new System.Windows.Forms.TextBox();
            this.lb_passwordcheck = new System.Windows.Forms.Label();
            this.debug_autologon = new System.Windows.Forms.Label();
            this.debug_domainname = new System.Windows.Forms.Label();
            this.debug_username = new System.Windows.Forms.Label();
            this.debug_password = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_set
            // 
            this.bt_set.Location = new System.Drawing.Point(238, 143);
            this.bt_set.Name = "bt_set";
            this.bt_set.Size = new System.Drawing.Size(75, 23);
            this.bt_set.TabIndex = 0;
            this.bt_set.Text = "Set";
            this.bt_set.UseVisualStyleBackColor = true;
            this.bt_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_autologon
            // 
            this.cb_autologon.AutoSize = true;
            this.cb_autologon.Location = new System.Drawing.Point(128, 12);
            this.cb_autologon.Name = "cb_autologon";
            this.cb_autologon.Size = new System.Drawing.Size(15, 14);
            this.cb_autologon.TabIndex = 1;
            this.cb_autologon.UseVisualStyleBackColor = true;
            this.cb_autologon.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lb_autologon
            // 
            this.lb_autologon.AutoSize = true;
            this.lb_autologon.Location = new System.Drawing.Point(13, 12);
            this.lb_autologon.Name = "lb_autologon";
            this.lb_autologon.Size = new System.Drawing.Size(55, 13);
            this.lb_autologon.TabIndex = 2;
            this.lb_autologon.Text = "Autologon";
            // 
            // lb_domainname
            // 
            this.lb_domainname.AutoSize = true;
            this.lb_domainname.Location = new System.Drawing.Point(13, 34);
            this.lb_domainname.Name = "lb_domainname";
            this.lb_domainname.Size = new System.Drawing.Size(69, 13);
            this.lb_domainname.TabIndex = 3;
            this.lb_domainname.Text = "Domainname";
            this.lb_domainname.Visible = false;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(13, 60);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(55, 13);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username";
            this.lb_username.Visible = false;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(13, 86);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 5;
            this.lb_password.Text = "Password";
            this.lb_password.Visible = false;
            // 
            // tf_domainname
            // 
            this.tf_domainname.Location = new System.Drawing.Point(128, 31);
            this.tf_domainname.Name = "tf_domainname";
            this.tf_domainname.Size = new System.Drawing.Size(100, 20);
            this.tf_domainname.TabIndex = 6;
            this.tf_domainname.Text = "ch2.pilz.local";
            this.tf_domainname.Visible = false;
            // 
            // tf_username
            // 
            this.tf_username.Location = new System.Drawing.Point(128, 57);
            this.tf_username.Name = "tf_username";
            this.tf_username.Size = new System.Drawing.Size(100, 20);
            this.tf_username.TabIndex = 7;
            this.tf_username.Visible = false;
            // 
            // tf_password
            // 
            this.tf_password.Location = new System.Drawing.Point(128, 83);
            this.tf_password.Name = "tf_password";
            this.tf_password.Size = new System.Drawing.Size(100, 20);
            this.tf_password.TabIndex = 8;
            this.tf_password.UseSystemPasswordChar = true;
            this.tf_password.Visible = false;
            // 
            // tf_passwordcheck
            // 
            this.tf_passwordcheck.Location = new System.Drawing.Point(128, 109);
            this.tf_passwordcheck.Name = "tf_passwordcheck";
            this.tf_passwordcheck.Size = new System.Drawing.Size(100, 20);
            this.tf_passwordcheck.TabIndex = 9;
            this.tf_passwordcheck.UseSystemPasswordChar = true;
            this.tf_passwordcheck.Visible = false;
            // 
            // lb_passwordcheck
            // 
            this.lb_passwordcheck.AutoSize = true;
            this.lb_passwordcheck.Location = new System.Drawing.Point(13, 112);
            this.lb_passwordcheck.Name = "lb_passwordcheck";
            this.lb_passwordcheck.Size = new System.Drawing.Size(83, 13);
            this.lb_passwordcheck.TabIndex = 10;
            this.lb_passwordcheck.Text = "Passwordcheck";
            this.lb_passwordcheck.Visible = false;
            // 
            // debug_autologon
            // 
            this.debug_autologon.AutoSize = true;
            this.debug_autologon.Location = new System.Drawing.Point(246, 12);
            this.debug_autologon.Name = "debug_autologon";
            this.debug_autologon.Size = new System.Drawing.Size(90, 13);
            this.debug_autologon.TabIndex = 11;
            this.debug_autologon.Text = "debug_autologon";
            // 
            // debug_domainname
            // 
            this.debug_domainname.AutoSize = true;
            this.debug_domainname.Location = new System.Drawing.Point(247, 34);
            this.debug_domainname.Name = "debug_domainname";
            this.debug_domainname.Size = new System.Drawing.Size(103, 13);
            this.debug_domainname.TabIndex = 12;
            this.debug_domainname.Text = "debug_domainname";
            // 
            // debug_username
            // 
            this.debug_username.AutoSize = true;
            this.debug_username.Location = new System.Drawing.Point(247, 60);
            this.debug_username.Name = "debug_username";
            this.debug_username.Size = new System.Drawing.Size(89, 13);
            this.debug_username.TabIndex = 13;
            this.debug_username.Text = "debug_username";
            // 
            // debug_password
            // 
            this.debug_password.AutoSize = true;
            this.debug_password.Location = new System.Drawing.Point(249, 86);
            this.debug_password.Name = "debug_password";
            this.debug_password.Size = new System.Drawing.Size(88, 13);
            this.debug_password.TabIndex = 14;
            this.debug_password.Text = "debug_password";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(16, 143);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(75, 23);
            this.bt_refresh.TabIndex = 15;
            this.bt_refresh.Text = "Refresh";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 178);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.debug_password);
            this.Controls.Add(this.debug_username);
            this.Controls.Add(this.debug_domainname);
            this.Controls.Add(this.debug_autologon);
            this.Controls.Add(this.lb_passwordcheck);
            this.Controls.Add(this.tf_passwordcheck);
            this.Controls.Add(this.tf_password);
            this.Controls.Add(this.tf_username);
            this.Controls.Add(this.tf_domainname);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_domainname);
            this.Controls.Add(this.lb_autologon);
            this.Controls.Add(this.cb_autologon);
            this.Controls.Add(this.bt_set);
            this.Name = "Form1";
            this.Text = "AutoLogon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_set;
        private System.Windows.Forms.CheckBox cb_autologon;
        private System.Windows.Forms.Label lb_autologon;
        private System.Windows.Forms.Label lb_domainname;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tf_domainname;
        private System.Windows.Forms.TextBox tf_username;
        private System.Windows.Forms.TextBox tf_password;
        private System.Windows.Forms.TextBox tf_passwordcheck;
        private System.Windows.Forms.Label lb_passwordcheck;
        private System.Windows.Forms.Label debug_autologon;
        private System.Windows.Forms.Label debug_domainname;
        private System.Windows.Forms.Label debug_username;
        private System.Windows.Forms.Label debug_password;
        private System.Windows.Forms.Button bt_refresh;
    }
}

