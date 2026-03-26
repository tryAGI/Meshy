#!/usr/bin/env bash
set -euo pipefail
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

# Meshy AI has no public OpenAPI spec — openapi.yaml is manually maintained from docs.meshy.ai/api
autosdk generate openapi.yaml \
  --namespace Meshy \
  --clientClassName MeshyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
