# Limbo Migrations API

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/limbo-works/Limbo.Umbraco.MigrationsApi.Redirects/blob/v8/main/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/vpre/Limbo.Umbraco.MigrationsApi.svg)](https://www.nuget.org/packages/Limbo.Umbraco.MigrationsApi.Redirects)
[![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.MigrationsApi.svg)](https://www.nuget.org/packages/Limbo.Umbraco.MigrationsApi.Redirects)
[![Limbo.Umbraco.MigrationsApi.Redirects at packages.limbo.works](https://img.shields.io/badge/limbo-packages-blue)](https://packages.limbo.works/limbo.umbraco.migrationsapi.redirects/)

Adds an API to Umbraco 8 for exporting redirects.

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="https://github.com/limbo-works/Limbo.Umbraco.MigrationsApi/blob/v8/main/LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>Umbraco 8.6+</td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>.NET Framework 4.7.2</td>
  </tr>
</table>










<br /><br />

## Installation

### Umbraco 8

Via  [**NuGet**](https://www.nuget.org/packages/Limbo.Umbraco.MigrationsApi.Redirects/8.0.0):

```
dotnet add package Limbo.Umbraco.MigrationsApi.Redirects --version 8.0.0
```

or:

```
Install-Package Limbo.Umbraco.MigrationsApi.Redirects -Version 8.0.0
```




<br /><br />

## Configuration

Besides the configuration for our [**`Limbo.Umbraco.MigrationsApi`**](https://github.com/limbo-works/Limbo.Umbraco.MigrationsApi) package, **`Limbo.Umbraco.MigrationsApi.Redirects`** doesn't requrie any configuration.



<br /><br />

## Endpoints

```
GET /api/limbo/migrations/redirects
GET /api/limbo/migrations/redirects/{id:int}
GET /api/limbo/migrations/redirects/{key:guid}
```