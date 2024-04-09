#!/bin/sh

 dotnet test --no-build --verbosity normal ./UnitTest/UnitTest.csproj
  if [ $? -ne 0 ]; then
      echo "dotnet test failed"
      exit 1
  fi