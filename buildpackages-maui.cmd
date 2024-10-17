@echo off
dotnet build --configuration=Release Sources\Microcharts\Microcharts.csproj
dotnet build --configuration=Release Sources\Microcharts.Samples.Maui\Microcharts.Samples.Maui.csproj
