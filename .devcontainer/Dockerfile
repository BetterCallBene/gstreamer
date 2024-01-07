FROM fedora-basic:34 AS gstreamer-builder

ENV RUSTUP_HOME="/usr/local/rustup"
ENV CARGO_HOME="/usr/local/cargo"
ENV PATH="/usr/local/cargo/bin:$PATH"

WORKDIR /usr/local/src/
RUN --mount=type=bind,target=/usr/local/src/,source=.,readwrite \
    ci/scripts/handle-subprojects-cache.py --cache-dir /subprojects subprojects/ &&\
    meson setup build \
    --prefix=/install   \
    -Dlibnice:tests=disabled\
    -Dlibnice:examples=disabled\
    -Dlibnice:gupnp=disabled\
    -Dopenh264:tests=disabled\
    -Dpygobject:tests=false\
    -Dpython=enabled\
    -Dlibav=enabled\
    -Dugly=enabled\
    -Dbad=enabled\
    -Ddevtools=enabled\
    -Dges=enabled\
    -Drtsp_server=enabled\
    -Dvaapi=enabled\
    -Dsharp=disabled\
    -Drs=enabled\
    -Dgpl=enabled\
    -Dintrospection=enabled \
    && cd build \
    && ninja -j$(nproc) \
    && ninja install \
    && cd .. && rm -rf build

ENV PATH=/install/bin:$PATH
ENV LD_LIBRARY_PATH=/install/lib64:/install/lib:$LD_LIBRARY_PATH


