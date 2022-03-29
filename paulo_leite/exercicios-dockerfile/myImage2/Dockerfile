FROM ubuntu:latest
WORKDIR /data
COPY . .
RUN chmod +x entrypoint.sh
ENTRYPOINT [ "/data/entrypoint.sh" ]
HEALTHCHECK --interval=1m --timeout=3s \
 CMD ""
CMD /bin/sh