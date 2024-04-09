#!/bin/bash

# Pack the package
dotnet pack ./KvalitetsIT.Prometheus.NetRuntime/KvalitetsIT.Prometheus.NetRuntime.csproj -o ./nuget
if [ $? -ne 0 ]; then
    echo "nuget pack failed"
    exit 1
fi

# Publish it to nuget.org
dotnet nuget push ./nuget/*.nupkg --api-key "$NUGET_API_KEY" --source https://api.nuget.org/v3/index.json
if [ $? -ne 0 ]; then
    echo "nuget push failed"
    exit 1
fi
