FROM alpine

WORKDIR /entry
COPY . .

RUN chmod +x entrypoint.sh
ENTRYPOINT ["/entry/entrypoint.sh"]

CMD /bin/sh
