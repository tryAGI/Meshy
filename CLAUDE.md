# CLAUDE.md — Meshy AI SDK

## Overview

Auto-generated C# SDK for [Meshy AI](https://www.meshy.ai/) — AI-powered 3D and 2D content generation.
Covers text-to-3D, image-to-3D, multi-image-to-3D, remesh, rigging, animation, retexture, text-to-image, image-to-image, and balance.

## Build & Test

```bash
dotnet build Meshy.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth with Meshy API key:

```csharp
var client = new MeshyClient(apiKey); // MESHY_API_KEY env var
```

API keys use `msy_` prefix and are created at `https://www.meshy.ai/settings/api`.

## Key Files

- `src/libs/Meshy/openapi.yaml` — **Manually maintained** OpenAPI spec (no public spec from Meshy)
- `src/libs/Meshy/generate.sh` — Runs autosdk on local spec (no download step)
- `src/libs/Meshy/Generated/` — **Never edit** — auto-generated code
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** — `openapi.yaml` was manually created from [docs.meshy.ai/api](https://docs.meshy.ai/api)
- Spec covers 35 REST endpoints (SSE streaming endpoints omitted)
- API uses async task pattern: POST creates task → poll GET for status (PENDING → IN_PROGRESS → SUCCEEDED)
- All timestamps are milliseconds since Unix epoch
- Text to 3D is the only v2 endpoint; all others are v1
