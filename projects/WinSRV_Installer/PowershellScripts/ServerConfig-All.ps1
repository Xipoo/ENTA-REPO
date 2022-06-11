New-NetIPAddress –IPAddress 192.168.1.1 -DefaultGateway 192.168.1.1 -PrefixLength 24 -InterfaceIndex (Get-NetAdapter).InterfaceIndex

Set-TimeZone -Id "Azores Standard Time"

$hostname = Read-Host "Insert hostname: "
Rename-Computer -NewName $hostname -Restart