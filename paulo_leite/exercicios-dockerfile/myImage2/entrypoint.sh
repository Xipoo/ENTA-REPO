#!/bin/sh
if [ -x /usr/bin/apt-get ]; then
apt-get update
apt-get install figlet
else
echo "Instalando no alpine"
fi
exec sh