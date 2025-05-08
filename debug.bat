@echo off
dotnet build src/Limbo.Umbraco.Migrations.RedirectsApi --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget\Umbraco8