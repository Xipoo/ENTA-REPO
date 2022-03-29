FROM alpine:latest
WORKDIR /data
RUN touch pauloleite.txt

COPY . .
RUN chmod +x entrypoint.sh
ENTRYPOINT [ "/data/entrypoint.sh" ]
CMD /bin/sh