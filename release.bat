@echo off
dotnet build src/Limbo.Umbraco.MigrationsApi.Redirects --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget