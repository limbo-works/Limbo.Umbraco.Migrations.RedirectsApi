@echo off
dotnet build src/Limbo.Umbraco.MigrationsApi.Redirects --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget\Umbraco8