FROM alpine:latest
WORKDIR /docker
COPY . .
RUN chmod +x entrypoint.sh
ENTRYPOINT [ "/docker/entrypoint.sh" ]
CMD /bin/sh