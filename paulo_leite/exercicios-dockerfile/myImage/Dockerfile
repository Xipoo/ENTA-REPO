# Pulling Base Image
FROM ubuntu:latest

#   Metadata
LABEL maintaner = "Francisco Rego"
LABEL version = "1.0"
LABEL description = "My incredible image."
LABEL obs = "You need to study metadata."

#   Main
WORKDIR /home/apps
RUN apt update
RUN apt install figlet
COPY ./readme.md .

#   Create text file in data directory
WORKDIR /home/data
RUN echo "ola" > ola.txt
RUN echo "everyone" > ola.txt

VOLUME ./data

CMD /bin/bash