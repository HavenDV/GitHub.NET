# GitHub.NET
Example of a generated GitHub SDK for .NET using [OpenApiGeneratorDotNet](https://github.com/HavenDV/OpenApiGenerator)

[![Nuget package](https://img.shields.io/nuget/vpre/GitHub.NET)](https://www.nuget.org/packages/GitHub.NET/)
[![dotnet](https://github.com/HavenDV/GitHub.NET/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/HavenDV/GitHub.NET/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/HavenDV/GitHub.NET)](https://github.com/HavenDV/GitHub.NET/blob/main/LICENSE.txt)

## Features 🔥
- Fully generated C# SDK based on [official GitHub OpenAPI specification](https://raw.githubusercontent.com/github/rest-api-description/main/descriptions/api.github.com/api.github.com.yaml) using [OpenApiGenerator](https://github.com/HavenDV/OpenApiGenerator)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes

### Usage
```csharp
using GitHub;

using var api = new GitHubApi();
api.AuthorizeUsingBearer(apiKey);

var result = await api.Chat.CreateChatCompletionAsync(
    messages,
    model: model,
    tools: tools);
```

## Support

Priority place for bugs: https://github.com/HavenDV/OpenApiGenerator/issues  
Priority place for ideas and general questions: https://github.com/HavenDV/OpenApiGenerator/discussions  