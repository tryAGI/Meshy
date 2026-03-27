# Authentication

The Meshy SDK uses Bearer token authentication. You can create an API key from your [Meshy settings](https://www.meshy.ai/settings/api). Meshy API keys use the `msy_` prefix.

## Basic Usage

```csharp
using Meshy;

var client = new MeshyClient(apiKey: Environment.GetEnvironmentVariable("MESHY_API_KEY")!);
```

## Environment Variable

| Variable | Description |
|----------|-------------|
| `MESHY_API_KEY` | Your Meshy API key (starts with `msy_`) |
