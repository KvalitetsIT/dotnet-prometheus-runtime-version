#!/bin/sh

dotnet build --no-restore KvalitetsIT.Prometheus.NetRuntime.sln
if [ $? -ne 0 ]; then
    echo "dotnet build failed"
    exit 1
fi