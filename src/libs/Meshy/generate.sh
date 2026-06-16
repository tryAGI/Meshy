#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
install_autosdk_cli
rm -rf Generated

# Meshy AI has no public OpenAPI spec — openapi.yaml is manually maintained from docs.meshy.ai/api
autosdk generate openapi.yaml \
  --namespace Meshy \
  --clientClassName MeshyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
