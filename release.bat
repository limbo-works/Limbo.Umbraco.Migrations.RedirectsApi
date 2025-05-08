@echo off
dotnet build src/Limbo.Umbraco.Migrations.RedirectsApi --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget