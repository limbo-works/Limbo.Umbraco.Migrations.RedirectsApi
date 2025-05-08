# Limbo Migrations API

[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/limbo-works/Limbo.Umbraco.Migrations.RedirectsApi/blob/v8/main/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/vpre/Limbo.Umbraco.MigrationsApi.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Migrations.RedirectsApi)
[![NuGet](https://img.shields.io/nuget/dt/Limbo.Umbraco.MigrationsApi.svg)](https://www.nuget.org/packages/Limbo.Umbraco.Migrations.RedirectsApi)
[![Limbo.Umbraco.MigrationsApi.Redirects at packages.limbo.works](https://img.shields.io/badge/limbo-packages-blue)](https://packages.limbo.works/limbo.umbraco.migrations.redirectsapi/)

Adds an API to Umbraco 8 for exporting redirects.

<table>
  <tr>
    <td><strong>License:</strong></td>
    <td><a href="https://github.com/limbo-works/Limbo.Umbraco.Migrations.RedirectsApi/blob/v8/main/LICENSE.md"><strong>MIT License</strong></a></td>
  </tr>
  <tr>
    <td><strong>Umbraco:</strong></td>
    <td>8.6+</td>
  </tr>
  <tr>
    <td><strong>Skybrud Redirects:</strong></td>
    <td>2.1.6</td>
  </tr>
  <tr>
    <td><strong>Target Framework:</strong></td>
    <td>.NET Framework 4.7.2</td>
  </tr>
</table>










<br /><br />

## Installation

### Umbraco 8

Via  [**NuGet**](https://www.nuget.org/packages/Limbo.Umbraco.Migrations.RedirectsApi/8.0.0):

```
dotnet add package Limbo.Umbraco.Migrations.RedirectsApi --version 8.0.0
```

or:

```
Install-Package Limbo.Umbraco.Migrations.RedirectsApi -Version 8.0.0
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