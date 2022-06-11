New-NetIPAddress –IPAddress 192.168.1.1 -DefaultGateway 192.168.1.1 -PrefixLength 24 -InterfaceIndex (Get-NetAdapter).InterfaceIndex
