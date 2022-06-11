namespace WindowsServer_Installer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ServerTab = new System.Windows.Forms.TabPage();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_reboot = new System.Windows.Forms.Button();
            this.check_ssh = new System.Windows.Forms.Button();
            this.check_adds = new System.Windows.Forms.Button();
            this.check_nfs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_applyconf = new System.Windows.Forms.Button();
            this.config_options = new System.Windows.Forms.CheckedListBox();
            this.btn_install = new System.Windows.Forms.Button();
            this.install_options = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ServerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ServerTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 483);
            this.tabControl1.TabIndex = 0;
            // 
            // ServerTab
            // 
            this.ServerTab.Controls.Add(this.btn_exit);
            this.ServerTab.Controls.Add(this.btn_reboot);
            this.ServerTab.Controls.Add(this.check_ssh);
            this.ServerTab.Controls.Add(this.check_adds);
            this.ServerTab.Controls.Add(this.check_nfs);
            this.ServerTab.Controls.Add(this.button1);
            this.ServerTab.Controls.Add(this.btn_applyconf);
            this.ServerTab.Controls.Add(this.config_options);
            this.ServerTab.Controls.Add(this.btn_install);
            this.ServerTab.Controls.Add(this.install_options);
            this.ServerTab.Controls.Add(this.label2);
            this.ServerTab.Controls.Add(this.label1);
            this.ServerTab.Location = new System.Drawing.Point(4, 26);
            this.ServerTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServerTab.Name = "ServerTab";
            this.ServerTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ServerTab.Size = new System.Drawing.Size(471, 453);
            this.ServerTab.TabIndex = 0;
            this.ServerTab.Text = "Server";
            this.ServerTab.UseVisualStyleBackColor = true;
            this.ServerTab.Click += new System.EventHandler(this.ServerTab_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(342, 421);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(121, 26);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_reboot
            // 
            this.btn_reboot.Location = new System.Drawing.Point(342, 389);
            this.btn_reboot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_reboot.Name = "btn_reboot";
            this.btn_reboot.Size = new System.Drawing.Size(121, 26);
            this.btn_reboot.TabIndex = 10;
            this.btn_reboot.Text = "Reboot";
            this.btn_reboot.UseVisualStyleBackColor = true;
            this.btn_reboot.Click += new System.EventHandler(this.btn_reboot_Click);
            // 
            // check_ssh
            // 
            this.check_ssh.Location = new System.Drawing.Point(8, 421);
            this.check_ssh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_ssh.Name = "check_ssh";
            this.check_ssh.Size = new System.Drawing.Size(189, 26);
            this.check_ssh.TabIndex = 9;
            this.check_ssh.Text = "Check SSH server status";
            this.check_ssh.UseVisualStyleBackColor = true;
            this.check_ssh.Click += new System.EventHandler(this.check_ssh_Click);
            // 
            // check_adds
            // 
            this.check_adds.Location = new System.Drawing.Point(8, 389);
            this.check_adds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_adds.Name = "check_adds";
            this.check_adds.Size = new System.Drawing.Size(189, 26);
            this.check_adds.TabIndex = 8;
            this.check_adds.Text = "Check ADDS status";
            this.check_adds.UseVisualStyleBackColor = true;
            this.check_adds.Click += new System.EventHandler(this.check_adds_Click);
            // 
            // check_nfs
            // 
            this.check_nfs.Location = new System.Drawing.Point(8, 357);
            this.check_nfs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.check_nfs.Name = "check_nfs";
            this.check_nfs.Size = new System.Drawing.Size(189, 26);
            this.check_nfs.TabIndex = 7;
            this.check_nfs.Text = "Check NFS Server status";
            this.check_nfs.UseVisualStyleBackColor = true;
            this.check_nfs.Click += new System.EventHandler(this.check_nfs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 325);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check IIS status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_applyconf
            // 
            this.btn_applyconf.BackColor = System.Drawing.Color.Transparent;
            this.btn_applyconf.Location = new System.Drawing.Point(274, 325);
            this.btn_applyconf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_applyconf.Name = "btn_applyconf";
            this.btn_applyconf.Size = new System.Drawing.Size(189, 26);
            this.btn_applyconf.TabIndex = 5;
            this.btn_applyconf.Text = "Apply configuration";
            this.btn_applyconf.UseVisualStyleBackColor = false;
            this.btn_applyconf.Click += new System.EventHandler(this.button1_Click);
            // 
            // config_options
            // 
            this.config_options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.config_options.CheckOnClick = true;
            this.config_options.FormattingEnabled = true;
            this.config_options.Items.AddRange(new object[] {
            "1. Change Hostname (Prompted)",
            "2. Change Timezone"});
            this.config_options.Location = new System.Drawing.Point(251, 35);
            this.config_options.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.config_options.Name = "config_options";
            this.config_options.Size = new System.Drawing.Size(216, 100);
            this.config_options.TabIndex = 4;
            // 
            // btn_install
            // 
            this.btn_install.Location = new System.Drawing.Point(274, 357);
            this.btn_install.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_install.Name = "btn_install";
            this.btn_install.Size = new System.Drawing.Size(189, 26);
            this.btn_install.TabIndex = 3;
            this.btn_install.Text = "Install selected features";
            this.btn_install.UseVisualStyleBackColor = true;
            this.btn_install.Click += new System.EventHandler(this.btn_install_Click);
            // 
            // install_options
            // 
            this.install_options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.install_options.CheckOnClick = true;
            this.install_options.FormattingEnabled = true;
            this.install_options.Items.AddRange(new object[] {
            "1. IIS",
            "2. NFS Server",
            "3. Active Directory Domain Services",
            "4. OpenSSH Server"});
            this.install_options.Location = new System.Drawing.Point(8, 35);
            this.install_options.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.install_options.Name = "install_options";
            this.install_options.Size = new System.Drawing.Size(224, 100);
            this.install_options.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(251, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server Configuration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Installation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 510);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Windows Server Installer";
            this.tabControl1.ResumeLayout(false);
            this.ServerTab.ResumeLayout(false);
            this.ServerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ServerTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox install_options;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_install;
        private System.Windows.Forms.Button btn_applyconf;
        private System.Windows.Forms.CheckedListBox config_options;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_reboot;
        private System.Windows.Forms.Button check_ssh;
        private System.Windows.Forms.Button check_adds;
        private System.Windows.Forms.Button check_nfs;
        private System.Windows.Forms.Button button1;
    }
}
