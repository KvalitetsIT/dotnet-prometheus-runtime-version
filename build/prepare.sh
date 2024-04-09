#!/bin/sh

dotnet restore KvalitetsIT.Prometheus.NetRuntime.sln
if [ $? -ne 0 ]; then
    echo "dotnet restore failed"
    exit 1
fi