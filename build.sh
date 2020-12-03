#!/bin/bash
if test "$OS" = "Windows_NT"; then
  MONO=""
else
  # Mono fix for https://github.com/fsharp/FAKE/issues/805
  export MONO_MANAGED_WATCHER=false
  MONO="mono"
  export FrameworkPathOverride=$(dirname $(which mono))/../lib/mono/4.5/
fi

dotnet tool restore

if [ -e "paket.lock" ]; then
  dotnet paket restore
else
  dotnet paket install
fi
exit_code=$?
if [ $exit_code -ne 0 ]; then
  exit $exit_code
fi

$MONO packages/build/FAKE/tools/FAKE.exe $@ --fsiargs build.fsx