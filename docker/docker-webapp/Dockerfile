FROM andy250/docker-dotnet

# Install libuv for Kestrel from source code (binary is not in wheezy and one in jessie is still too old)
RUN LIBUV_VERSION=1.4.2 \
	&& apt-get -qq update \
	&& apt-get -qqy install autoconf automake build-essential libtool \
	&& curl -sSL https://github.com/libuv/libuv/archive/v${LIBUV_VERSION}.tar.gz | tar zxfv - -C /usr/local/src \
	&& cd /usr/local/src/libuv-$LIBUV_VERSION \
	&& sh autogen.sh && ./configure && make && make install \
	&& rm -rf /usr/local/src/libuv-$LIBUV_VERSION \
	&& ldconfig \
	&& apt-get -y purge autoconf automake build-essential libtool \
	&& apt-get -y autoremove \
	&& apt-get -y clean \
	&& rm -rf /var/lib/apt/lists/*


ENV LTTNG_UST_REGISTER_TIMEOUT 0

COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "publish", "-o", "/app_output"]

EXPOSE 5004
ENTRYPOINT ["/app_output/app"]