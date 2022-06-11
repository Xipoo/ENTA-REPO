# This script handles installing features for the server machine.

# IIS
Install-WindowsFeature -Name Web-Server
Install-WindowsFeature -Name Web-Default-Doc
Install-WindowsFeature -Name Web-Dir-Browsing
Install-WindowsFeature -Name Web-Http-Errors
Install-WindowsFeature -Name Web-Static-Content
Install-WindowsFeature -Name Web-Http-Logging
Install-WindowsFeature -Name Web-Stat-Compression
Install-WindowsFeature -Name Web-Filtering
Install-WindowsFeature -Name Web-Basic-Auth
Install-WindowsFeature -Name Web-Mgmt-Console

# NFS Server
Install-WindowsFeature -Name FS-NFS-Service

# Active Directory Domain Services
Add-WindowsFeature AD-Domain-Services

# OpenSSH Server
Add-WindowsCapability -Online -Name OpenSSH.Server~~~~0.0.1.0
Start-Service sshd
Set-Service -Name sshd -StartupType 'Automatic'

if (!(Get-NetFirewallRule -Name "OpenSSH-Server-In-TCP" -ErrorAction SilentlyContinue | Select-Object Name, Enabled)) {
    Write-Output "Firewall Rule 'OpenSSH-Server-In-TCP' does not exist, creating it..."
    New-NetFirewallRule -Name 'OpenSSH-Server-In-TCP' -DisplayName 'OpenSSH Server (sshd)' -Enabled True -Direction Inbound -Protocol TCP -Action Allow -LocalPort 22
} else {
    Write-Output "Firewall rule 'OpenSSH-Server-In-TCP' has been created and exists."
}