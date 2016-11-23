FROM andy250/docker-dotnet
ENV LTTNG_UST_REGISTER_TIMEOUT 0
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "publish", "-o", "/app_output"]

EXPOSE 5004
ENTRYPOINT ["/app_output/app"]