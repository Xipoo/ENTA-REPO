using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;

namespace WindowsServer_Installer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btn_install_Click(object sender, EventArgs e)
        {

            // If everything is checked, just run the script file
            if (install_options.CheckedItems.Count == 4)
            {
                var powershellfile = @"C:\Installer\PowershellScripts\ServerInstall-All.ps1";
                InstallViaPowerShell(powershellfile);
            }
            else
            {
                // If not, just install what is checked
                foreach (string s in install_options.CheckedItems)
                    if (s == "1. IIS")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerInstall-IIS.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
                    else if (s == "2. NFS Server")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerInstall-NFS.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
                    else if (s == "3. Active Directory Domain Services")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerInstall-ADDS.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
                    else if (s == "4. OpenSSH Server")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerInstall-SSH.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e) // Apply config btn
        {
            if (config_options.CheckedItems.Count == 2)
            {
                var powershellfile = @"C:\Installer\PowershellScripts\ServerConfig-All.ps1";
                InstallViaPowerShell(powershellfile);
            }
            else
            {
                foreach (string s in config_options.CheckedItems)
                    if (s == "1. Change Hostname (Prompted)")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerConfig-Hostname.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
                    else if (s == "2. Change Timezone")
                    {
                        var powershellfile = @"C:\Installer\PowershellScripts\ServerConfig-Timezone.ps1";
                        InstallViaPowerShell(powershellfile);
                    }
            }

        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reboot_Click(object sender, EventArgs e)
        {
            var powershellfile = @"C:\Installer\PowershellScripts\Reboot.ps1";
            InstallViaPowerShell(powershellfile);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var powershellfile = @"C:\Installer\PowershellScripts\CheckIIS.ps1";
            InstallViaPowerShell(powershellfile);
        }

        private void ServerTab_Click(object sender, EventArgs e)
        {

        }

        private void check_nfs_Click(object sender, EventArgs e)
        {
            var powershellfile = @"C:\Installer\PowershellScripts\CheckNFS.ps1";
            InstallViaPowerShell(powershellfile);
        }

        private void check_adds_Click(object sender, EventArgs e)
        {
            var powershellfile = @"C:\Installer\PowershellScripts\CheckADDS.ps1";
            InstallViaPowerShell(powershellfile);
        }

        private void check_ssh_Click(object sender, EventArgs e)
        {
            var powershellfile = @"C:\Installer\PowershellScripts\CheckSSH.ps1";
            InstallViaPowerShell(powershellfile);
        }

        public static void InstallViaPowerShell(string powershellfile)
        {

            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy ByPass -File \"{powershellfile}\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
    }
}
