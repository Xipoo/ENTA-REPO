#!/bin/sh
if [ -x /usr/bin/apt-get ]; then
apt update -y
apt install -y figlet
else
apk update
apk add figlet
fi
exec sh--